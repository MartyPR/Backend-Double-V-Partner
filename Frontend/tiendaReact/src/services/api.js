import axios from 'axios';

const api = axios.create({
  baseURL: 'https://fakeapi.platzi.com',
});

export const getProductos = () => api.get('/products');
export const getProductoDetalle = (id) => api.get(`/products/${id}`);
