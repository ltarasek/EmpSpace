import React from 'react';
import { Link } from 'react-router-dom'

import './EmpStartPage.css';

export default class EmpStartPage extends React.Component {
    render() {
        return (
            <Link to={"/emp/" + this.props.id}>
                <div className='EmpCard' >
                    <h4>{this.props.name} {this.props.lastName}</h4>
                    <div className='avatar'></div>
                </div>
            </Link>
        );
    }
} 