import React from 'react'

export default class EmployeePersonalData extends React.Component {
    render() {
        return (
            <div>
                <span>Imię: {this.props.name}</span>
                <br/>
                <span>Nazwisko: {this.props.lastName}</span>
                <br/>
                <span>Adres: {this.props.address} {this.props.city}</span> 
            </div>
        );
    }
}