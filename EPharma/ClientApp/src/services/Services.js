
class Services {

    

    async get() {
        fetch("https://localhost:44393/api/client")
            .then(res => res.json())
            .then(
                (result) => {                   
                    this.setState({
                        items: result.items

                    })
                },
                (error) => {
                    this.setState({
                        isLoaded: true,
                        error
                    });
                }
        )        
    }

}

export default Services;