import React from 'react';
import Dialog from '@mui/material/Dialog';
import DialogActions from '@mui/material/DialogActions';
import DialogContent from '@mui/material/DialogContent';
import DialogContentText from '@mui/material/DialogContentText';
import DialogTitle from '@mui/material/DialogTitle';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
import CircularProgress from '@mui/material/CircularProgress';
import Alert from '@mui/material/Alert';


function App() {
    return (
        <div>
            <Dialog open="true">
                <Alert severity="error">This is an error alert — check it out!</Alert>

                <Alert severity="success">This is a success alert — check it out!</Alert>
                <DialogTitle>Tax File Number Validator</DialogTitle>
                <DialogContent>
                    <DialogContentText>
                        Enter Tax File Number Here
                    </DialogContentText>

                    <TextField
                        autoFocus
                        margin="dense"
                        id="tfn-input"
                        label="Tax File Number"
                        type="text"
                        fullWidth
                        variant="standard"
                    />
                </DialogContent>

                <DialogActions>
                    <CircularProgress />
                    <Button variant="contained">Validate</Button>
                </DialogActions>

            </Dialog>
           
        </div>
    );
} export default App;