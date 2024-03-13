import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App.jsx'

import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";

import "./style/flexboxgrid.min.css";
import './style/index.css';

import { Provider } from 'react-redux';
import { store } from "./store/store"

import { BrowserRouter } from 'react-router-dom';

ReactDOM.createRoot(document.getElementById('root')).render(
  <React.StrictMode>
    <React.StrictMode>
        <Provider store={store}>
            <BrowserRouter>
                <App />
            </BrowserRouter>
        </Provider>      
    </React.StrictMode>
  </React.StrictMode>,
)
