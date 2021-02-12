import React from 'react';
import './App.css';
import Home from './components/pages/Home';
import AboutUs from './components/pages/AboutUs';
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';
import Navbar from './components/Navbar/Navbar';
import Footer from './components/Footer/Footer';

function App() {
  return (
    <Router>
      <Navbar />
      <Switch>
        <Route path='/' exact component={Home} />
        <Route path='/aboutUs' component={AboutUs} />
      </Switch>
      <Footer />
    </Router>
  );
}

export default App;
