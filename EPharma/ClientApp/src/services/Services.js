
class Services {
    constructor() {
        this.state = {
            items: [],

        };
    }
    

    async get() {

        fetch("https://localhost:44393/api/client")
            .then(res => res.json())
            .then(result => this.setState({ items: result }))

        console.log(this.state.items);
    }
   
}

export default Services;