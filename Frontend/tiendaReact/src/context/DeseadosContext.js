import React, { createContext, useState } from 'react';

export const DeseadosContext = createContext();

export const DeseadosProvider = ({ children }) => {
  const [deseados, setDeseados] = useState([]);

  const agregarDeseado = (producto) => {
    setDeseados([...deseados, producto]);
  };

  const eliminarDeseado = (id) => {
    setDeseados(deseados.filter(producto => producto.id !== id));
  };

  return (
    <DeseadosContext.Provider value={{ deseados, agregarDeseado, eliminarDeseado }}>
      {children}
    </DeseadosContext.Provider>
  );
};
