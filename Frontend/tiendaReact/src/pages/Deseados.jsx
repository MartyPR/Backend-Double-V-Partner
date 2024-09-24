import React, { useContext } from 'react';
import { DeseadosContext } from '../context/DeseadosContext';


const Deseados = () => {
  const { deseados, eliminarDeseado } = useContext(DeseadosContext);

  return (
    <div>
      <h2>Productos deseados</h2>
      {deseados.map(producto => (
        <div key={producto.id}>
          <h3>{producto.name}</h3>
          <button onClick={() => eliminarDeseado(producto.id)}>Eliminar</button>
        </div>
      ))}
    </div>
  );
};

export default Deseados;
