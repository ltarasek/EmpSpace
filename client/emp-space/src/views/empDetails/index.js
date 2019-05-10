import React from 'react';
import { Link } from 'react-router-dom'

import { GetEmp } from '../../services/empService';
import EmployeePersonalDetails from '../../components/EmpDetailsComponents/EmployeePersonalData'

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
                <EmployeePersonalDetails 
                name = {emp.name} 
                lastName={emp.lastName} 
                address={emp.address} 
                city={emp.city} 
                phone = {emp.phone}
                birthday = {emp.birthday}
                />

            </div>
        );
    }
}