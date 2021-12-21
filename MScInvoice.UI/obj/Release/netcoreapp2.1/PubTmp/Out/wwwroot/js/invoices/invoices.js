var app = new Vue({
    el: '#app',

    data: {
        loading: false,
        isDisabledCustomer: true,
        isSeenCustomer: false,
        checkButton: "Show",
        objectIndex: 0,
        editing: false,
        sections: [{
            name: "Section 1",
            inputs: [],
            subSum: 0
         }],
        
        customers: [],
        selectedPayMethod: {
            id: 0,
            name: ''
        },
        items: [],
        payMethods: [],
        invoices: [],
        invoice: {},
        selectedCustomer: {
            id: null,
            name: null,
            address1: null,
            address2: null,
            postCode: null,
            city: null,
            number1: null
        },
        selectedItem: {
            id: 0,
            name: null,
            price: null,
            tax: null
        },
        InvoiceVM: {
            InvoiceId: null,
            CustomerId: 0,
            CustomerName: " ",
            CustomerAddress1: " ",
            CustomerAddress2: " ",
            CustomerCity: " ",
            CustomerPostCode: " ",
            CustomerNumber1: " ",

            InvoiceDueDate: null,

            PayMethodId: 0,
            Sections: []
        },
    },
    
    mounted() {
        this.getCustomers(),
        this.getItems(),
        this.getPayMethods(),
            this.getInvoices()

    },
    computed: {
        sumTotal: function () {
            var sumTotal2 = 0;
            this.sections.forEach(section => {
                  sumTotal2 += section.inputs.reduce(function (previousValue, currentValue) {
                      totalLine = parseFloat(currentValue.totalLine);
                      if (!isNaN(totalLine)) {
                          return previousValue + totalLine;
                    }
                }, 0);
            });
               
            if (!isNaN(sumTotal2)) {
                return sumTotal2.toFixed(2)
            }
            return 0;
        },
        totalTax: function () {
            var totalTax2 = 0;
            this.sections.forEach(section => {
                totalTax2 += section.inputs.reduce(function (previousValue, currentValue) {
                    totalLineTax = parseFloat(currentValue.totalLineTax);
                    if (!isNaN(totalLineTax)) {
                        return previousValue + totalLineTax;
                    }
                }, 0);
            });

            if (!isNaN(totalTax2)) {
                return totalTax2.toFixed(2)
            }
            return 0;
        },
        totalPlusTax: function () {
            var totalPlusTax2 = (parseFloat(this.sumTotal) + parseFloat(this.totalTax))
            if (!isNaN(totalPlusTax2)) {
                return totalPlusTax2.toFixed(2);
            }
            return 0;
        }
    },
    methods: {

        test() {
        },
        showHideCustomer: function() {
            this.isSeenCustomer = !this.isSeenCustomer;
            this.checkButton = this.isSeenCustomer ? 'Hide' : 'Show';
               
        },
        addCustomer() {
            this.isDisabledCustomer = false;
            this.isSeenCustomer = true;
            this.checkButton = 'Hide';
            this.selectedCustomer = {
                id: 0,
                name: null,
                address1: null,
                address2: null,
                postCode: null,
                city: null,
                number1: null
            };
        },
        getInvoice(id) {
            this.loading = true;
            axios.get('/invoices/' + id)
                .then(res => {
    
                    var invoice = res.data;
                    
                    this.selectedCustomer = {
                        id: invoice.customerId,
                        name: invoice.customerName,
                        address1: invoice.customerAddress1,
                        address2: invoice.customerAddress2,
                        postCode: invoice.customerPostCode,
                        city: invoice.customerCity,
                        number1: invoice.customerNumber1
                        
                    };
                    this.invoice = {
                        InvoiceId: invoice.id,
                        InvoiceNumber: invoice.invoiceNo,
                        InvoiceDate: invoice.date,
                        InvoiceDescription: invoice.description,
                       DueDate: invoice.invoiceDueDate,   

                    };
                    this.selectedPayMethod = {
                        id: invoice.payMethodId,
                        name: invoice.payMethodName
                    },

                        console.log(this.invoice.DueDate);

                    //display sections
                    this.sections = [];
                    var subSum2 = 0;

                    invoice.invoiceSections.forEach((section, index) => {
                        this.sections.push({
                            id: section.id,
                            name: section.name,
                            date: section.date,
                            inputs: [],
                            subSum: 0
                        });

                        //dispaly items for each section
                        section.invoiceItem.forEach(item => {
                            this.sections[index].inputs.push({
                                id: item.itemId,
                                quantity: item.quantity,
                                name: item.itemName,
                                price: item.itemPrice,
                                tax: item.itemTax,
                                totalLine: item.itemPrice * item.quantity,
                                totalLineTax: ((item.itemPrice * item.quantity) * (item.itemTax / 100))
                            });
                        });

                        subSum2 = this.sections[index].inputs.reduce(function (previousValue, currentValue) {
                            totalLine = parseFloat(currentValue.totalLine);
                            if (!isNaN(totalLine)) {
                                return previousValue + totalLine;
                            }
                        }, 0);
                        this.sections[index].subSum = subSum2.toFixed(2);

                        console.log("subSum");
                        console.log(subSum2);
                        
                    });
                    
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        getInvoices() {
            this.loading = true;
            axios.get('/invoices')
                .then(res => {
                    console.log(res);
                    this.invoices = res.data;
                    
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        createInvoice() {
            this.loading = true;

            var sections2 = [];
            var items2 = [];
            this.sections.forEach(section => {

                section.inputs.forEach(input => {
                    items2.push({
                        ItemId: input.id,
                        Name: input.name,
                        Price: input.price,
                        Tax: input.tax,
                        Quantity: input.quantity
                    })
                })
                console.log("items2");
                console.log(items2)
                sections2.push(
                    {
                        Name: section.name,
                        Items: items2
                    }
                )
                items2 = [];
            });
  
            axios.post('/invoices', this.InvoiceVM = {
                CustomerId: this.selectedCustomer.id,
                CustomerName: this.selectedCustomer.name,
                CustomerAddress1: this.selectedCustomer.address1,
                CustomerAddress2: this.selectedCustomer.address2,
                CustomerCity: this.selectedCustomer.city,
                CustomerPostCode: this.selectedCustomer.postCode,
                CustomerNumber1: this.selectedCustomer.number1,

                InvoiceDueDate: this.invoice.DueDate,

                PayMethodId: this.selectedPayMethod.id,
                Sections: sections2   
            })
                .then(res => {
                    console.log(res);
                    this.invoices.push(res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    
                    this.editing = false;
                    this.loading = false;
                });
        },
        editInvoice(id, index) {
            this.objectIndex = index;
            this.getInvoice(id);
            this.editing = true;
        },
        newInvoice() {
            
            this.editing = true;
            this.selectedCustomer = {};
            this.invoice = { DueDate: new Date().toISOString().substr(0, 10) }
            this.selectedPayMethod = this.payMethods[0];
            this.sections = [{
                name: "Section 1",
                inputs: [],
                subSum: 0
            }];
        },
        cancel() {
            this.editing = false;
        },
        printInvoice() {
            //window.location.href = "/PdfCreator/" + this.invoice.InvoiceId;
            window.open("/PdfCreator/" + this.invoice.InvoiceId);
        },
        updateInvoice() {
            this.loading = true;

            var sections2 = [];
            var items2 = [];
            this.sections.forEach(section => {
               
                section.inputs.forEach(input => {
                    items2.push({
                        ItemId: input.id,
                        Name: input.name,
                        Price: input.price,
                        Tax: input.tax,
                        Quantity: input.quantity
                    })
                   
                })
                console.log("items2");
                console.log(items2);
                sections2.push(
                    {
                        Name: section.name,
                        Date: section.date,
                        Items: items2
                    }
                )
                items2 = [];
            });

            axios.put('/invoices', this.InvoiceVM = {
                InvoiceId: this.invoice.InvoiceId,
                CustomerId: this.selectedCustomer.id,
                CustomerName: this.selectedCustomer.name,
                CustomerAddress1: this.selectedCustomer.address1,
                CustomerAddress2: this.selectedCustomer.address2,
                CustomerCity: this.selectedCustomer.city,
                CustomerPostCode: this.selectedCustomer.postCode,
                CustomerNumber1: this.selectedCustomer.number1,

                InvoiceDueDate: this.invoice.DueDate,

                PayMethodId: this.selectedPayMethod.id,
                Sections: sections2
            })
                .then(res => {
                    console.log(res.data);
                    this.invoices.splice(this.objectIndex, 1, res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    alert("Invoice Updated Successfully");
                    this.loading = false;
                });
        },
        deleteInvoice(id, index) {
            this.loading = true;
            axios.delete('/invoices/' + id)
                .then(res => {
                    console.log(res);
                    this.invoices.splice(index, 1);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        addSectionToInvoice() {
            this.sections.push({
                name: "Section " + (this.sections.length + 1),
                inputs: [],
                subSum: 0
            });
        },
        addItemToInvoice(index) {

            var subSum2 = 0;
            if (this.selectedItem.id === undefined) {
                this.selectedItem.id = 0;
            };
            this.sections[index].inputs.push({
                id: this.selectedItem.id,
                name: this.selectedItem.name,
                price: this.selectedItem.price,
                tax: this.selectedItem.tax,
                quantity: 1,
                totalLine: this.selectedItem.price * 1,
                totalLineTax: ((this.selectedItem.price * 1) * (this.selectedItem.tax / 100))
            });

            subSum2 = this.sections[index].inputs.reduce(function (previousValue, currentValue) {
                totalLine = parseFloat(currentValue.totalLine);
                if (!isNaN(totalLine)) {
                    return previousValue + totalLine;
                }
            }, 0);
            this.sections[index].subSum = subSum2.toFixed(2);  
        },
        deleteItemFromInvoice(indexSection, indexItem) {
            this.sections[indexSection].inputs.splice(indexItem, 1)
        },
        deleteSectionFromInvoice(indexSection) {
            this.sections.splice(indexSection, 1)
        },
        calculateTotalLine(input, indexSection) {
            var total = parseFloat(input.price) * parseFloat(input.quantity);
            var totalTax = (parseFloat(input.price) * parseFloat(input.quantity)) * (parseFloat(input.tax) / 100);

           
            if (!isNaN(total)) {
                input.totalLine = total.toFixed(2);
            }
            if (!isNaN(totalTax)) {
                input.totalLineTax = totalTax;
            }

            ///////////////////////////////////////////////////////////////
            // calculation subSum for each section
            var subSum2 = this.sections[indexSection].inputs.reduce(function (previousValue, currentValue) {
                totalLine = parseFloat(currentValue.totalLine);
                if (!isNaN(totalLine)) {
                    return previousValue + totalLine;
                }
            }, 0);
            this.sections[indexSection].subSum = subSum2.toFixed(2);

        },
        customerSelection(selection) {
            this.selectedCustomer = selection;
            console.log(selection.name + ' has been selected');
        },
        itemSelection(selection) {
            this.selectedItem = selection;
            console.log(selection.name + ' has been selected');
        },
        getDropdownValues(keyword) {
            console.log('You could refresh options by querying the API with ' + keyword);
        },
        getCustomers() {
            this.loading = true;
            axios.get('/customers')
                .then(res => {
                    console.log(res);
                    this.customers = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        getItems() {
            this.loading = true;
            axios.get('/items')
                .then(res => {
                    console.log(res);
                    this.items = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        getPayMethods() {
            this.loading = true;
            axios.get('/payMethods')
                .then(res => {
                    console.log(res);
                    this.payMethods = res.data;
                    console.log("PayMethodsArray")
                    console.log(this.payMethods)
                    this.selectedPayMethod = this.payMethods[0];
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
    }
})