class Scripture
{

    private string _refKey;

    private string _refValue;

    public Scripture (string refKey, string refValue){
        this._refKey = refKey;
        this._refValue = refValue;
    }


    public string getRefKey(){
        return this._refKey;
    }

    public void setRefKey(string refKey){
        this._refKey = refKey;
    }

    public string getRefValue(){
        return this._refValue;
    }

    public void setRefValue(string refValue){
        this._refValue = refValue;
    }




}
