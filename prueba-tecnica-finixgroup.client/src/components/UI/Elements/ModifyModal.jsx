import React from 'react';
import styled from 'styled-components';

export default function ModifyModal({ bankItem, onClose, onRemove }) {
    return (
        <ModalOverlay>
            <ModalContent>
                <h2>Modify Bank</h2>
                <p>ID: {bankItem.id}</p>
                <p>Bank Name: {bankItem.bank_name}</p>
                <hr></hr>
            <ModalFooter>
              <Button onClick={onClose}>Close</Button>
              <Button onClick={onRemove}>Modify</Button>
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