export interface OrdersBetween {
    dateFrom: Date,
    dateTo: Date
}


export interface ReturnfromOrdersBetween {
  Menu_Item_Id: number;
    Menu_Item_Name: string;
    Menu_Item_Price: string;
    Order_Date_Created: Date;
    Order_Date_Completed:Date;
}
