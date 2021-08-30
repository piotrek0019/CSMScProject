var app = new Vue({
    el: '#app',

    data: {
        loading: false,
        isDisabledCustomer: true,
        isSeenCustomer: false,
        checkButton: "Show",
        inputs: [],
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
            Items: [
                {
                    ItemId: 0,
                    Name: " ",
                    Price: 0
                }
            ]
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
            return this.inputs.reduce(function (previousValue, currentValue) {
                subSum = parseFloat(currentValue.subSum);
                if (!isNaN(subSum)) {
                    return previousValue + subSum;
                }
            }, 0).toFixed(2);
        }
    },
    methods: {

        test() {
            let items = [];
            this.inputs.forEach(input => {
                items.push(
                    {
                        ItemId: input.id,
                        Name: input.name,
                        Price: input.price,
                        Quantity: input.quantity
                    }
                )
            });
            console.log("Selected Items")
            console.log(items)
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
            var items = [];
            this.inputs.forEach(input => {
                items.push(
                    {
                        ItemId: input.id,
                        Name: input.name,
                        Price: input.price,
                        Quantity: input.quantity
                    }
                )
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
                Items: items
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
        addItemToInvoice() {
            if (this.selectedItem.id === undefined) {
                this.selectedItem.id = 0;
            };
            this.inputs.push({
                id: this.selectedItem.id,
                name: this.selectedItem.name,
                price: this.selectedItem.price,
                quantity: 1,
                subSum: this.selectedItem.price * 1
            });
            
        },
        deleteItemFromInvoice(index) {
            this.inputs.splice(index, 1)
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