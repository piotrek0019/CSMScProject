var app = new Vue({
    el: '#app',

    data: {
        loading: false,
        isDisabledCustomer: true,
        isSeenCustomer: false,
        checkButton: "Show",
        sections: [{
                name: "Section " + "1",
                inputs: []
         }],
        
        customers: [],
        selectedPayMethod: 0,
        items: [],
        payMethods: [],
        invoices: [],
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
            price: null
        },
        InvoiceVM: {
            CustomerId: 0,
            CustomerName: " ",
            CustomerAddress1: " ",
            CustomerAddress2: " ",
            CustomerCity: " ",
            CustomerPostCode: " ",
            CustomerNumber1: " ",

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
                var sumTotal2 =  this.sections.inputs.reduce(function (previousValue, currentValue) {
                    subSum = parseFloat(currentValue.subSum);
                    if (!isNaN(subSum)) {
                        return previousValue + subSum;
                    }
                }, 0);
            if (!isNaN(sumTotal2)) {
                return sumTotal2.toFixed(2)
            }
            return 0;
        }
    },
    methods: {

        test() {
            var sections2 = [];
            var items2 = [];
            this.sections.forEach(section => {

                section.inputs.forEach(input => {
                    items2.push({
                        ItemId: input.id,
                        Name: input.name,
                        Price: input.price,
                        Quantity: input.quantity
                    })
                });
                console.log("items2");
                console.log(items2);
                sections2.push({
                    Name: section.name,
                    Items: items2
                });
                items2 = [];
            });
            
            console.log(this.sections);
            console.log("sections2");
            console.log(sections2)
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
                    console.log(res);
                    var invoice = res.data;
                    var sections = [];
                    var items = [];
                    invoice.invoiceSections.forEach(section => {
                        sections.push({
                            id: section.id,
                            name: section.name,
                            invoiceItem: section.invoiceItem
                        })
                        section.invoiceItem.forEach(item => {
                            items.push({
                                quantity: item.quantity,
                                name: item.itemName,
                                price: item.itemPrice
                            })
                        })
                    });
                    
                    console.log(sections);
                    console.log(items);
                   
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
                PayMethodId: this.selectedPayMethod,
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
                    this.loading = false;
                });
        },
        editInvoice(id, index) {
            this.objectIndex = index;
            this.getInvoice(id);
            
        },
        addSectionToInvoice() {
            this.sections.push({
                name: "Section " + (this.sections.length + 1),
                inputs: []
            });
        },
        addItemToInvoice(index) {
            if (this.selectedItem.id === undefined) {
                this.selectedItem.id = 0;
            };
            this.sections[index].inputs.push({
                id: this.selectedItem.id,
                name: this.selectedItem.name,
                price: this.selectedItem.price,
                quantity: 1,
                subSum: this.selectedItem.price * 1
            });
            
        },
        deleteItemFromInvoice(indexSection, indexItem) {
            this.sections[indexSection].inputs.splice(indexItem, 1)
        },
        calculateSubSum(input) {
            var total = parseFloat(input.price) * parseFloat(input.quantity);
            if (!isNaN(total)) {
                input.subSum = total.toFixed(2);
            }
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
                    this.selectedPayMethod = this.payMethods[0].id;
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