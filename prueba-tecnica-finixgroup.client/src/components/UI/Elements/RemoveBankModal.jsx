import React from 'react';
import styled from "styled-components";
import {deleteById} from "../../../store/apiServices";

export default function RemoveBankModal({ bankItem, onClose}) {

  const handleRemove = () => {
    deleteById(bankItem.id)
        .then(() => {
            window.location.reload();
        })
        .catch((error) => {
            console.error('Error removing bank:', error);
        });
  };
  
  return (
      <ModalOverlay>
          <ModalContent>
              <h1 className='font20 bold'>Remove Bank</h1>
              <p>ID: {bankItem.id}</p>
              <p>Bank Name: {bankItem.bank_name}</p>
              <h1 className="font18 semiBold">Are you sure?</h1>
              <hr></hr>
            <ModalFooter>
              <Button onClick={onClose}>Close</Button>
              <Button onClick={handleRemove}>Remove</Button>
            </ModalFooter>
          </ModalContent>
      </ModalOverlay>
  );
}

const ModalOverlay = styled.div`
position: fixed;
top: 0;
left: 0;
width: 100%;
height: 100%;
background-color: rgba(0, 0, 0, 0.01);
display: flex;
justify-content: center;
align-items: center;
z-index: 999;
`;

const ModalContent = styled.div`
background-color: white;
padding: 20px;
border-radius: 4px;
animation: slideIn 0.3s ease-out forwards;
transform: translateY(100%);
@keyframes slideIn {
    from {
        transform: translateY(100%);
    }
    to {
        transform: translateY(0);
    }
}
`;

const ModalFooter = styled.div`
background-color: white;
text-align:center;
`;

const Button = styled.button`

margin: 10px;
padding: 8px 16px;
background-color: #505050;
color: white;
border: none;
border-radius: 4px;
cursor: pointer;
`;