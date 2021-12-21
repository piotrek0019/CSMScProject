var app = new Vue({
    el: '#app',
    data: {
        editing: false,
        id: 0,
        loading: false,
        objectIndex: 0,
        customerModel: {
            id: 0,
            name: "Customer Name",
            address1: "Address 1",
            address2: "Address 2",
            postCode: "Post Code",
            city: "City",
            number1: "Indetification Number"
        },
        customers: []
    },
    mounted() {
        this.getCustomers()
    },
    methods: {
        getCustomer(id) {
            this.loading = true;
            axios.get('/customers/' + id)
                .then(res => {
                    console.log(res);
                    var customer = res.data;
                    this.customerModel = {
                        id: customer.id,
                        name: customer.name,
                        address1: customer.address1,
                        address2: customer.address2,
                        postCode: customer.postCode,
                        city: customer.city,
                        number1: customer.number1,
                    }
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
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
        createCustomer() {
            loading: true,
                axios.post('/customers', this.customerModel)
                .then(res => {
                    console.log(res.data);
                    this.customers.push(res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    loading: false;
                    this.editing = false;
                });
        },
        updateCustomer() {
            this.loading = true;
            axios.put('/customers', this.customerModel)
                .then(res => {
                    console.log(res.data);
                    this.customers.splice(this.objectIndex, 1, res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        editCustomer(id, index) {
            this.objectIndex = index;
            this.getCustomer(id);
            this.editing = true;
        },
        deleteCustomer(id, index) {
            this.loading = true;
            axios.delete('/customers/' + id)
                .then(res => {
                    console.log(res);
                    this.customers.splice(index, 1);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        newCustomer() {
            this.editing = true;
            this.customerModel.id = 0;
        },
        cancel() {
            this.editing = false;
        }
    },
});