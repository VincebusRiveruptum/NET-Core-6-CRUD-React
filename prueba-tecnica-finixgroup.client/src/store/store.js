import { configureStore } from "@reduxjs/toolkit";
import bankSlice from "./bankSlice";


const reducer = {
    bankList: bankSlice
};

const store = configureStore({
    reducer: reducer
});


export const rootReducer = reducer;

export { store };

export const RootState = store.getState;
export const AppDispatch = store.dispatch;