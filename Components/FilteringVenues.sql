SELECT 
    v.VenueID, 
    v.Capacity, 
    b.BuildingName 
FROM 
    Venue v
JOIN 
    Building b ON v.BuildingID = b.BuildingID
JOIN 
    VenueEquipment ve1 ON v.VenueID = ve1.VenueID
JOIN 
    Equipment e1 ON ve1.EquipmentID = e1.EquipmentID
JOIN 
    VenueEquipment ve2 ON v.VenueID = ve2.VenueID
JOIN 
    Equipment e2 ON ve2.EquipmentID = e2.EquipmentID
WHERE 
    e1.EquipmentName = 'Whiteboard' 
    AND e2.EquipmentName = 'Chairs'
    AND ve1.EquipmentID <> ve2.EquipmentID;
