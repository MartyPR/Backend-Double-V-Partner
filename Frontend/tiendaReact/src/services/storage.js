import { Storage } from '@ionic/storage';

const store = new Storage();
store.create();

export const saveDeseados = async (deseados) => {
  await store.set('deseados', deseados);
};

export const getDeseados = async () => {
  return await store.get('deseados');
};
