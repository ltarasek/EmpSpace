import React from 'react';
import { Link } from 'react-router-dom'

import { GetEmp } from '../../services/empService';

export default class EmpDetails extends React.Component {
    constructor(props) {
        super(props);

        this.state = { employee: null };
    }

    componentDidMount() {
        GetEmp(this.props.match.params.empId).then(emp => {
            this.setState({
                employee: emp
            });
        });
    }

    render() {
        if (!this.state.employee) { return "Loading..."; }
        var emp = this.state.employee;
        return (
            <div>
                <Link to={"/"}>
                    <div>HOME</div>
                </Link>
                <h3>{emp.name} {emp.lastName}</h3>
                <h3>{emp.address} {emp.postalCode} {emp.city} {emp.country}</h3>

            </div>
        );
    }
}