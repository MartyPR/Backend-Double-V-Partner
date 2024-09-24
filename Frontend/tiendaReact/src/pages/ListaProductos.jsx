import React, { useState, useEffect, useContext } from 'react';
import { getProductos } from '../services/api';
import { DeseadosContext } from '../context/DeseadosContext';

const ListaProductos = () => {
  const [productos, setProductos] = useState([]);
  const { agregarDeseado } = useContext(DeseadosContext);

  useEffect(() => {
    const fetchProductos = async () => {
      const result = await getProductos();
      setProductos(result.data);
    };
    fetchProductos();
  }, []);

  return (
    <div>
      {productos.map(producto => (
        <div key={producto.id}>
          <h3>{producto.name}</h3>
          <button onClick={() => agregarDeseado(producto)}>Agregar a deseados</button>
        </div>
      ))}
    </div>
  );
};

export default ListaProductos;
