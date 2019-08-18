import React, { Component } from 'react';

export class Filter extends Component {

    constructor(props) {
        super(props);
        this.state = { filtername: '', categories: '' };


        this.handleFilterNameChange = this.handleFilterNameChange.bind(this);
                this.handleCategoriesChange = this.handleCategoriesChange.bind(this);

    this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleSubmit(event) {

        event.preventDefault();
        fetch('https://localhost:5001/api/filter/', {
            method: 'post',
            body: JSON.stringify(this.state)
        }).then(function (response) {
            return response.json();
        }).then(function (data) {
            console.log(data);
        });
    }

  

        handleFilterNameChange(event) {
            this.setState({ filtername: event.target.value });
        }

     handleCategoriesChange(event) {
            this.setState({ categories: event.target.value });
        }

  render() {
    return (
      <div>
            <h1>Filter</h1>
            <h2>Add new Filter </h2>
            <form onSubmit={this.handleSubmit}>
  <label>
    Filtername:
    <input type="text" name="name" value={this.state.filtername} onChange={this.handleFilterNameChange}/>
  </label>
    <label>
    Categories:
    <input type="text" name="name" value={this.state.categories} onChange={this.handleCategoriesChange} />
  </label>

  <input type="submit" value="Submit" />
            </form>

            <h2>Show all the Filters </h2>


            


      </div>
    );
  }
}

