import React from 'react';
import './EmpStartPage.css';

export default class EmpStartPage extends React.Component{
    render(){
        return(
            <div className='EmpCard'>
                <h4>{this.props.name} {this.props.lastName}</h4>
                <div className='avatar'></div>
            </div>
        );
    }
} 