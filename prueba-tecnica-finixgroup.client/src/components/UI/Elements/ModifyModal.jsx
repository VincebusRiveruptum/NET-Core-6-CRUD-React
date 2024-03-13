import React from 'react';
import styled from "styled-components";
export default function ModifyModal({ bank, onClose }) {
    return (
        <Modal>
            <div class="modal-content">

                <div class="modal-header">
                    <span class="close">&times;</span>
                    <h1 className="font18">header</h1>
                </div>
                <div class="modal-body">
                    <span class="close">&times;</span>
                    <h1 className="font18">body</h1>
                </div>
                <div class="modal-footer">
                    <span class="close">&times;</span>
                    <h1 className="font18">footery</h1>
                </div>
            </div>
        </Modal>
    )
}

const Modal = styled.div`
.modal {
    display: none; /* Hidden by default */
    position: fixed; /* Stay in place */
    z-index: 1; /* Sit on top */
    left: 0;
    top: 0;
    width: 100%; /* Full width */
    height: 100%; /* Full height */
    overflow: auto; /* Enable scroll if needed */
    background-color: rgb(0,0,0); /* Fallback color */
    background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
    -webkit-animation-name: fadeIn; /* Fade in the background */
    -webkit-animation-duration: 0.4s;
    animation-name: fadeIn;
    animation-duration: 0.4s  
  }
  
  /* Modal Content */
  .modal-content {
    position: fixed;
    bottom: 0;
    
    padding:1%;
    width: 80%;
    -webkit-animation-name: slideIn;
    -webkit-animation-duration: 0.4s;
    animation-name: slideIn;
    animation-duration: 0.4s
    @media(max-width:760px){
        width: 100%;
    }

  }
  
  /* The Close Button */
  .close {
    color: white;
    float: right;
    font-size: 28px;
    font-weight: bold;
  }
  
  .close:hover,
  .close:focus {
    color: #000;
    text-decoration: none;
    cursor: pointer;
  }
  
  .modal-header {
    background-color: #5cb85c;
    color: white;
    border-radius:5px;
    padding:2%;
    @media(max-width:760px){
        padding:1%;
        width: 100%;
    }
  }
  
  .modal-body {
    padding: 2px 16px;}
  
  .modal-footer {
    padding: 2px 16px;
    background-color: #5cb85c;
    color: white;
  }
  
  /* Add Animation */
  @-webkit-keyframes slideIn {
    from {bottom: -300px; opacity: 0} 
    to {bottom: 0; opacity: 1}
  }
  
  @keyframes slideIn {
    from {bottom: -300px; opacity: 0}
    to {bottom: 0; opacity: 1}
  }
  
  @-webkit-keyframes fadeIn {
    from {opacity: 0} 
    to {opacity: 1}
  }
  
  @keyframes fadeIn {
    from {opacity: 0} 
    to {opacity: 1}
  }
`;
