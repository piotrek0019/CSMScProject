var app = new Vue({
    el: '#app',
  
    data: {
        loading: false,
        inputs: [],
        customers: [],
        selectedPayMethod: ' ',
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
            id: null,
            name: null,
            price: null
        },
        InvoiceVM: {
            CustomerId: 0,
            PayMethodId: 0,
            Items: []
        },
            
    },
    mounted() {
        this.getCustomers(),
        this.getItems(),
        this.getPayMethods()
    },
    methods: {
        createInvoice() {
            this.loading = true;
            axios.post('/invoices', {
                    CustomerId: 1,
                    PayMethodId: 1,
                    Items: [
                        { ItemId: 1 },
                        { ItemId: 2 },
                        { ItemId: 3 }
                    ]
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
        addRow() {
            this.inputs.push({
                one: this.selectedItem.id,
                two: this.selectedItem.name
            })
        },
        deleteRow(index) {
            this.inputs.splice(index, 1)
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