Vue.component('Dropdown', {
    
    template: `<div class="dropdown" v-if="options">

                <!-- Dropdown Input -->
                <input class="dropdown-input"
                  :name="name"
                  @focus="showOptions()"
                  @blur="exit()"
                  @keyup="keyMonitor"
                  v-model="searchFilter"
                  :disabled="disabled"
                  :placeholder="placeholder" />

                <!-- Dropdown Menu -->
                <div class="dropdown-content"
                  v-show="optionsShown">
                  <div
                    class="dropdown-item"
                    @mousedown="selectOption(option)"
                    v-for="(option, index) in filteredOptions"
                    :key="index">
                      {{ option.name || option.id || '-' }}
                  </div>
                </div>
              </div>`,
    props: {
        name: {
            type: String,
            required: false,
            default: 'dropdown',
            note: 'Input name'
        },
        options: {
            type: Array,
            required: true,
            default: [],
            note: 'Options of dropdown. An array of options with id and name',
        },
        placeholder: {
            type: String,
            required: false,
            default: 'Please select an option',
            note: 'Placeholder of dropdown'
        },
        disabled: {
            type: Boolean,
            required: false,
            default: false,
            note: 'Disable the dropdown'
        },
        maxItem: {
            type: Number,
            required: false,
            default: 6,
            note: 'Max items showing'
        }
    },
    data() {
        return {
            selected: {},
            optionsShown: false,
            searchFilter: '',
        }
    },
    created() {
        this.$emit('selected', this.selected);
    },
    computed: {
        filteredOptions() {
            const filtered = [];
            const regOption = new RegExp(this.searchFilter, 'ig');
            for (const option of this.options) {
                if (this.searchFilter.length < 1 || option.name.match(regOption)) {
                    if (filtered.length < this.maxItem) filtered.push(option);
                }
            }
            return filtered;
        }
    },
    methods: {
        selectOption(option) {
            this.selected = option;
            this.optionsShown = false;
            this.searchFilter = this.selected.name;
            this.$emit('selected', this.selected);
        },
        showOptions() {
            if (!this.disabled) {
                this.searchFilter = '';
                this.optionsShown = true;
            }
        },
        exit() {
            if (!this.selected.id) {
                this.selected = {};
                this.searchFilter = '';
            } else {
                this.searchFilter = this.selected.name;
            }
            this.$emit('selected', this.selected);
            this.optionsShown = false;
        },
        // Selecting when pressing Enter
        keyMonitor: function (event) {
            if (event.key === "Enter" && this.filteredOptions[0])
                this.selectOption(this.filteredOptions[0]);
        }
    },
    watch: {
        searchFilter() {
            if (this.filteredOptions.length === 0) {
                this.selected = {};
            } else {
                this.selected = this.filteredOptions[0];
            }
            this.$emit('filter', this.searchFilter);
        }
    }
});