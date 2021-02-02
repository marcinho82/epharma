import React, { Component } from 'react';


export class Home extends Component {
    displayName = Home.name  

    constructor(props) {
        super(props);
        this.state = {
            items: [],         
            name: "",
            registro : "",
            data: "",
            update : []
        };
       
    } 


    getDados() {

        fetch("https://localhost:44393/api/client")
            .then(res => res.json())
            .then(result => this.setState({ items: result }))
    }

    handleChange(e) {  

        if (e.target.value === "") {
            this.setState.update = this.getDados();
            this.setState.update = this.state.items.filter(item => item.nome.includes(this.state.name)).filter(item => item.cpfCnpj.includes(this.state.registro)).filter(item => item.dtCadastro.includes(this.state.data));
            
        }

        if (e.target.name === "nome") {
            this.setState.update = this.state.items.filter(item => item.nome.includes(e.target.value));
            this.setState({ name: e.target.value });
        }
        if (e.target.name === "registro") {
            this.setState.update = this.state.items.filter(item => item.cpfCnpj.includes(e.target.value));
            this.setState({ registro: e.target.value });
        }
        if (e.target.name === "data") {
            this.setState.update = this.state.items.filter(item => item.dtCadastro.includes(e.target.value));    
            this.setState({ data: e.target.value });
        }               
          
             
        
        this.setState({ items: this.setState.update });
       
    }

   
    componentDidMount() {

        this.getDados();              
    }

    render() {       
    return (
        <div>           
         
            <table>                      
                <thead>
                    <tr>
                        <th>Nome</th>
                        <th>CPF / CNPJ</th>
                        <th>Data de Cadastro</th>
                    </tr>
                    <tr>
                        <td><input type="text" onChange={this.handleChange.bind(this)} name="nome" /></td>
                        <td><input type="text" onChange={this.handleChange.bind(this)} name="registro"/></td>
                        <td><input type="text" onChange={this.handleChange.bind(this)} name="data" /></td>
                    </tr>
                </thead>
                <tbody>       
                   
                {this.state.items.map((item, i) =>

                    <tr key={i}>
                        <td>{item.nome}</td>
                        <td>{item.cpfCnpj}</td>
                        <td>{item.dtCadastro}</td>
                   </tr>

                 )
                    }
                    </tbody>
            </table>
           
      </div>
    );
  }
}
