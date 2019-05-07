import React from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom'


import StartPage from './views/startPage/index.js';
import EmpDetails from './views/empDetails/index.js';

export default class App extends React.Component {
    render() {
        return (
            <BrowserRouter>
            <Switch>
                <Route exact path="/" component={StartPage} />
                <Route path="/emp/:empId" component={EmpDetails} />
            </Switch>
            </BrowserRouter>
        );
    }
}
