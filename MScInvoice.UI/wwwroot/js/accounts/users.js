var app = new Vue({
    el: '#app',
    data: {
        editing: false,
        name: "",
        loading: false,
        objectIndex: 0,
        userModel: {
            id: "",
            username: "",
            password: ""
        },
        users: []
       
    },
    mounted() {
        this.getUsers()
    },
    methods: {
        createUser() {
            this.loading = true;
            axios.post('/users', this.userModel)
                .then(res => {
                    console.log(res);
                })
                .catch(err => {
                    console.log(err);
                }).then(() => {
                    this.loading = false;
                    this.editing = false;
                    location.reload();
                });
        },
        getUser(name) {
            this.loading = true;
            axios.get('/users/' + name)
                .then(res => {
                    console.log(res);
                    var user = res.data;
                    this.userModel = {
                        id: user.id,
                        username: user.userName,
                        
                    }
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    
                    this.loading = false;
                });
        },
        getUsers() {
            this.loading = true;
            axios.get('/users')
                .then(res => {
                    console.log(res);
                    this.users = res.data;
                })
                .catch(err => {
                    console.log(err);
                }).then(() => {
                    this.loading = false;
                });
        },
        editUser(name, index) {
            this.objectIndex = index;
            this.getUser(name);
            this.editing = true;
        },
        updateUser() {
            this.loading = true;
            axios.put('/users', this.userModel)
                .then(res => {
                    console.log(res.data);
                    this.users.splice(this.objectIndex, 1, res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        newUser() {
            this.editing = true;
            this.userModel.id = 0;
        },
        cancel() {
            this.editing = false;
        }
    }

});