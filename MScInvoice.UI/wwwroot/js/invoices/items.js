var app = new Vue({
    el: '#app',
    data: {
        editing: false,
        id: 0,
        loading: false,
        objectIndex: 0,
        itemModel: {
            id: 0,
            name: "Item Name",
            price: 1.99
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
                        price: item.price
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
            this.loading = true;
            axios.post('/items', this.itemModel)
                .then(res => {
                    console.log(res.data);
                    this.items.push(res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        updateItem() {
            this.loading = true;
            axios.put('/items', this.itemModel)
                .then(res => {
                    console.log(res.data);
                    this.items.splice(this.objectIndex, 1, res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        editItem(id, index) {
            this.objectIndex = index;
            this.getItem(id);
            this.editing = true;
        },
        deleteItem(id, index) {
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
                });
        },
        newItem() {
            this.editing = true;
            this.itemModel.id = 0;
        },
        cancel() {
            this.editing = false;
        }
    },
    computed: {
       
    }
});