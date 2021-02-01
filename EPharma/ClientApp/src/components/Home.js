import React, { Component } from 'react';
import services from '../services/Services';


export class Home extends Component {
    displayName = Home.name  
    constructor(props) {
        super(props);
        this.state = {
            items: []
        };
    } 
    //constructor(props) {
    //    super(props);
    //    this.services = new services();
    //}

    componentDidMount() {

        fetch("https://localhost:44393/api/client")
            .then(res => res.json())
            .then(result => this.setState({ items: result }))

    }
       

    render() {       
    return (
      <div>
           
      </div>
    );
  }
}
