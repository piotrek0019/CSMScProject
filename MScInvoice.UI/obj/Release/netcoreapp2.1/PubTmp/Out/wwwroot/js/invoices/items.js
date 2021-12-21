var app = new Vue({
    el: '#app',
    data: {
        priceIsValid: true,
        taxIsValid: true,
        nameIsValid: true,
        formIsValid: true,

        editing: false,
        id: 0,
        loading: false,
        objectIndex: 0,
        itemModel: {
            id: 0,
            name: "Item Name",
            price: 1.99,
            tax: 20
        },
        items: []
    },


    mounted() {
        this.getItems()
    },
    methods: {
        getItem(id) {
            this.loading = true;
            axios.get('/items/' + id)
                .then(res => {
                    console.log(res);
                    var item = res.data;
                    this.itemModel = {
                        id: item.id,
                        name: item.name,
                        price: item.price,
                        tax: item.tax
                    }
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
        createItem() {
            this.priceIsValid = typeof this.itemModel.price === 'number' && this.itemModel.price >= 0;
            this.taxIsValid = typeof this.itemModel.tax === 'number' && this.itemModel.tax >= 0 && this.itemModel.tax < 100;
            this.nameIsValid = !!this.itemModel.name

            this.formIsValid = this.priceIsValid
                && this.taxIsValid
                && this.nameIsValid;
            if (this.formIsValid) {
                this.loading = true;
                axios.post('/items', this.itemModel)
                    .then(res => {
                        console.log(res.data);
                        this.items.push(res.data);
                    })
                    .catch(err => {
                        this.formIsValid = false;
                        console.log(err);
                    })
                    .then(() => {
                        this.loading = false;
                        if (!this.formIsValid) {
                            this.editing = true;
                        }
                        else {
                            this.editing = false;
                        }
                    });
            }
            else {
                console.log("NOT VALID");
                console.log(this.itemModel.tax)
            }
        },
        updateItem() {
            
            this.priceIsValid = typeof this.itemModel.price === 'number' && this.itemModel.price > 0;
            this.taxIsValid = typeof this.itemModel.tax === 'number' && this.itemModel.tax >= 0 && this.itemModel.tax < 100;
            this.nameIsValid = !!this.itemModel.name

            this.formIsValid = this.priceIsValid && this.taxIsValid && this.nameIsValid

            if (this.formIsValid) {


                this.loading = true;
                axios.put('/items', this.itemModel)
                    .then(res => {
                        console.log(res.data);
                        this.items.splice(this.objectIndex, 1, res.data);
                    })
                    .catch(err => {
                        this.formIsValid = false;
                        console.log(err);
                        
                    })
                    .then(() => {
                        console.log("VALID");
                       
                        this.loading = false;
                        if (!this.formIsValid) {
                            this.editing = true;
                        }
                        else {
                            this.editing = false;
                        }
                    });
            }
            else {
                console.log("NOT VALID");
            }
        },
        editItem(id, index) {
            this.objectIndex = index;
            this.getItem(id);
            this.editing = true;
        },
        deleteItem(id, index) {
            if (confirm("Are you sure you want to delete this item")) {
                this.loading = true;
                axios.delete('/items/' + id)
                    .then(res => {
                        console.log(res);
                        this.items.splice(index, 1);
                    })
                    .catch(err => {
                        console.log(err);
                    })
                    .then(() => {
                        this.loading = false;
                        alert("Item deleted...")
                    });
            } 
        },
        newItem() {
            this.editing = true;
            this.itemModel.id = 0;
        },
        cancel() {
            this.editing = false;
            this.priceIsValid = true,
                this.taxIsValid = true,
                this.nameIsValid = true,
            this.formIsValid = true
        }
    },
    computed: {
       
    }
});