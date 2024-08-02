CREATE TABLE Empresas (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100) NOT NULL,
    direccion VARCHAR(255),
    telefono VARCHAR(15),
    email VARCHAR(100),
    nif VARCHAR(20) NOT NULL
);

-- Datos de prueba
INSERT INTO Empresas (nombre, direccion, telefono, email, nif) VALUES
('Empresa 1', 'Calle Falsa 123', '123456789', 'contacto@empresa1.com', 'A12345678'),
('Empresa 2', 'Avenida Siempre Viva 742', '987654321', 'info@empresa2.com', 'B87654321');

CREATE TABLE Clientes (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100) NOT NULL,
    direccion VARCHAR(255),
    telefono VARCHAR(15),
    email VARCHAR(100),
    dni VARCHAR(20) NOT NULL
);

-- Datos de prueba
INSERT INTO Clientes (nombre, direccion, telefono, email, dni) VALUES
('Juan Perez', 'Calle Falsa 456', '321654987', 'juan.perez@mail.com', '12345678X'),
('Maria Gomez', 'Avenida Siempre Viva 123', '654987321', 'maria.gomez@mail.com', '87654321Y');

CREATE TABLE Familias (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100) NOT NULL
);

-- Datos de prueba
INSERT INTO Familias (nombre) VALUES
('Electr�nica'),
('Ropa'),
('Alimentos');

CREATE TABLE Subfamilias (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100) NOT NULL,
    familia_id INT,
    FOREIGN KEY (familia_id) REFERENCES Familias(id)
);

-- Datos de prueba
INSERT INTO Subfamilias (nombre, familia_id) VALUES
('M�viles', 1),
('Televisores', 1),
('Camisetas', 2),
('Pantalones', 2),
('Frutas', 3),
('Bebidas', 3);

CREATE TABLE Articulos (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100) NOT NULL,
    descripcion VARCHAR(255),
    precio DECIMAL(10, 2) NOT NULL,
    stock INT NOT NULL,
    iva DECIMAL(4, 2) NOT NULL,
    subfamilia_id INT,
    FOREIGN KEY (subfamilia_id) REFERENCES Subfamilias(id)
);

-- Datos de prueba
INSERT INTO Articulos (nombre, descripcion, precio, stock, iva, subfamilia_id) VALUES
('iPhone 12', 'Tel�fono m�vil Apple', 799.99, 50, 21.00, 1),
('Samsung Galaxy S21', 'Tel�fono m�vil Samsung', 699.99, 30, 21.00, 1),
('TV LG 55"', 'Televisor 4K LG', 499.99, 20, 21.00, 2),
('Camiseta Adidas', 'Camiseta deportiva', 29.99, 100, 21.00, 3),
('Pantal�n Levis', 'Pantal�n vaquero', 59.99, 60, 21.00, 4),
('Manzana', 'Fruta fresca', 1.99, 200, 10.00, 5),
('Coca-Cola', 'Bebida refrescante', 0.99, 500, 10.00, 6);

CREATE TABLE Facturas (
    id INT PRIMARY KEY IDENTITY(1,1),
    cliente_id INT,
    empresa_id INT,
    fecha DATE NOT NULL,
    total DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (cliente_id) REFERENCES Clientes(id),
    FOREIGN KEY (empresa_id) REFERENCES Empresas(id)
);

-- Datos de prueba
INSERT INTO Facturas (cliente_id, empresa_id, fecha, total) VALUES
(1, 1, '2024-01-15', 1200.50),
(2, 2, '2024-01-20', 450.75);

CREATE TABLE DetallesFactura (
    factura_id INT,
    articulo_id INT,
    cantidad INT NOT NULL,
    precio_unitario DECIMAL(10, 2) NOT NULL,
    iva DECIMAL(4, 2) NOT NULL,
    PRIMARY KEY (factura_id, articulo_id),
    FOREIGN KEY (factura_id) REFERENCES Facturas(id),
    FOREIGN KEY (articulo_id) REFERENCES Articulos(id)
);

-- Datos de prueba
INSERT INTO DetallesFactura (factura_id, articulo_id, cantidad, precio_unitario, iva) VALUES
(1, 1, 2, 799.99, 21.00),
(1, 4, 5, 29.99, 21.00),
(2, 6, 10, 0.99, 10.00);