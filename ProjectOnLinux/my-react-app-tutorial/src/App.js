// App.js
import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import ProductList from './components/ProductList';
import CreateProduct from './components/CreateProduct';
import EditProduct from './components/EditProduct';

function App() {
  return (
    <Router>
      <div className="App">
        <Routes>
          <Route exact path="/" element={<ProductList/>} />
          <Route path="/create" element={<CreateProduct/>} />
          <Route path="/edit/:id" element={<EditProduct/>} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;