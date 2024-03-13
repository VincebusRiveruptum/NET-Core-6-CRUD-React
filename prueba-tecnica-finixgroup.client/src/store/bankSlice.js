import { createSlice, createAsyncThunk } from '@reduxjs/toolkit';
import { fetchBanks } from './apiServices';

const initialState = {
    items: [],
    status: 'idle',
    error: null
};

export const fetchBanksAsync = createAsyncThunk('banks/fetchBanks', async () => {
    return await fetchBanks();
});

export const bankList = createSlice({
    name:'bankList',
    initialState,
    reducers:{
        addBank:(state,action) => {
            state.items.push(action.payload)
        },
        getByID: (state, action) => {
            const filteredItems = state.items.filter((bank) => bank.id == action.payload);
            console.log(action.payload);
            state.items = filteredItems;

        },
        getByGUID: (state, action) => {
            const filteredItems = state.items.filter((bank) => bank.uid == action.payload.toLowerCase());
            state.items = filteredItems;
        }
    },
    extraReducers: (builder) => {
        builder
            .addCase(fetchBanksAsync.pending, (state) => {
                state.status = 'loading';
            })
            .addCase(fetchBanksAsync.fulfilled, (state, action) => {
                state.status = 'succeeded';
                state.items = action.payload;
                
            })
            .addCase(fetchBanksAsync.rejected, (state, action) => {
                state.status = 'failed';
                state.error = action.error.message;
            });
    },
});

export const { addBank, getByGUID, getByID } = bankList.actions;
export default bankList.reducer;