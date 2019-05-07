import React from 'react';
import './startPage.css';

import { GetAllEmp } from '../../services/empService';
import EmpStartPage from '../../components/EmpStartPage/index';

export default class StartPage extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            employee: []
        };
    }

    componentDidMount() {
        GetAllEmp().then(empFromService => {
            this.setState({
                employee: empFromService
            })
        });

    }

    render() {
        if (this.state.employee.length === 0) { return "Loading..."; }

        var employee = this.state.employee.map(emp => {
            return <EmpStartPage key={"emp-key-" + emp.id} name={emp.name} lastName={emp.lastName} id={emp.id} />
        });

        return (
            <div>
                <h1>Hello!</h1>
                {employee}
            </div>
        );
    }
} 