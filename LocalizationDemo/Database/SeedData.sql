USE LocalizationDemo;
GO

-- add data into service_type
INSERT INTO service_type (id, name) VALUES 
(1, 'Coding'),
(6, 'Diagnose Base'),
(11, 'ECU Update'),
(16, 'ECU Replacement'),
(21, 'Immobiliser Base'),
(26, 'Key Programming'),
(31, 'Reset / Adaption'),
(36, 'Retrofit'),
(41, 'Secure Gateway');

-- add data into service_type_localization
INSERT INTO service_type_localization (service_type_id, language_code, localized_name) VALUES 
(1, 'da-DK', 'Kodning (10 Credits) Old'),
(6, 'da-DK', 'Diagnose (5 Credits)'),
(11, 'da-DK', 'ECU opdatering (15 Credits)'),
(16, 'da-DK', 'ECU udskiftning (15 Credits)'),
(21, 'da-DK', 'Startspærre (5 Credits)'),
(26, 'da-DK', 'Nøgleprogrammering (5 Credits)'),
(36, 'da-DK', 'Eftermontering (10 Credits)'),
(41, 'da-DK', 'Secure Gateway (5 Credits)');
GO
