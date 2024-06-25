// CreateProduct.js
import React, { useState } from 'react';
import axios from 'axios';

function CreateProduct() {
  const [name, setName] = useState('');
  const [price, setPrice] = useState('');

  const handleSubmit = (event) => {
    event.preventDefault();

    const product = {
      name: name,
      price: price
    };

    axios.defaults.baseURL = 'http://localhost:5011';
    axios.post('/api/products', product)
      .then(response => {
        console.log('Product created successfully: ', response.data);
      })
      .catch(error => {
        console.error('Error creating product: ', error);
      });
  };

  return (
    <div>
      <h2>Create Product</h2>
      <form onSubmit={handleSubmit}>
        <div>
          <label>Name:</label>
          <input type="text" value={name} onChange={e => setName(e.target.value)} />
        </div>
        <div>
          <label>Price:</label>
          <input type="text" value={price} onChange={e => setPrice(e.target.value)} />
        </div>
        <button type="submit">Create</button>
      </form>
    </div>
  );
}

export default CreateProduct;