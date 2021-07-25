var app = new Vue({
    el: '#app',
    data: {
        editing: false,
        id: 0,
        loading: false,
        objectIndex: 0,
        payMethodModel: {
            id: 0,
            name: "Pay Method Name",
          
        },
        payMethods: []
    },
    mounted() {
        this.getPayMethods()
    },
    methods: {
        getPayMethod(id) {
            this.loading = true;
            axios.get('/payMethods/' + id)
                .then(res => {
                    console.log(res);
                    var payMethod = res.data;
                    this.payMethodModel = {
                        id: payMethod.id,
                        name: payMethod.name,
                    }
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
        createPayMethod() {
            loading: true,
                axios.post('/payMethods', this.payMethodModel)
                    .then(res => {
                        console.log(res.data);
                        this.payMethods.push(res.data);
                    })
                    .catch(err => {
                        console.log(err);
                    })
                    .then(() => {
                        loading: false;
                        this.editing = false;
                    });
        },
        updatePayMethod() {
            this.loading = true;
            axios.put('/payMethods', this.payMethodModel)
                .then(res => {
                    console.log(res.data);
                    this.payMethods.splice(this.objectIndex, 1, res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        editPayMethod(id, index) {
            this.objectIndex = index;
            this.getPayMethod(id);
            this.editing = true;
        },
        deletePayMethod(id, index) {
            this.loading = true;
            axios.delete('/payMethods/' + id)
                .then(res => {
                    console.log(res);
                    this.payMethods.splice(index, 1);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        newPayMethod() {
            this.editing = true;
            this.payMethodModel.id = 0;
        },
        cancel() {
            this.editing = false;
        }
    },
});