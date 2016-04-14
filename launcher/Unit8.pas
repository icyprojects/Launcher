unit Unit8;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.Buttons,
  Vcl.Imaging.jpeg, Vcl.ExtCtrls;

type
  TForm8 = class(TForm)
    Image1: TImage;
    Image2: TImage;
    Image3: TImage;
    Image4: TImage;
    Image5: TImage;
    Image6: TImage;
    Memo1: TMemo;
    Image7: TImage;
    procedure Image1MouseEnter(Sender: TObject);
    procedure Image1MouseLeave(Sender: TObject);
    procedure Image1MouseDown(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure Image1MouseUp(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure Image1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Image2Click(Sender: TObject);
    procedure Image2MouseDown(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure Image2MouseEnter(Sender: TObject);
    procedure Image2MouseLeave(Sender: TObject);
    procedure Image2MouseUp(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure Image3MouseDown(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure Image3MouseEnter(Sender: TObject);
    procedure Image3MouseLeave(Sender: TObject);
    procedure Image3MouseUp(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure Image4MouseDown(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure Image4MouseEnter(Sender: TObject);
    procedure Image4MouseLeave(Sender: TObject);
    procedure Image4MouseUp(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure Image5MouseUp(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure Image5MouseDown(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure Image5MouseEnter(Sender: TObject);
    procedure Image5MouseLeave(Sender: TObject);
    procedure Image6MouseDown(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure Image6MouseEnter(Sender: TObject);
    procedure Image6MouseLeave(Sender: TObject);
    procedure Image6MouseUp(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form8: TForm8;

  dt_normal, dt_hovered, dt_pressed : TBitMap;
  ofdm_normal, ofdm_hovered, ofdm_pressed : TBitMap;
  qam_auto_normal, qam_auto_hovered, qam_auto_pressed : TBitMap;
  qam_manual_normal, qam_manual_hovered, qam_manual_pressed : TBitMap;
  spectrum_normal, spectrum_hovered, spectrum_pressed : TBitMap;
  cdf_normal, cdf_hovered, cdf_pressed : TBitMap;
implementation

{$R *.dfm}
{$R buttons.RES}

procedure TForm8.FormCreate(Sender: TObject);
begin
memo1.Clear;
dt_normal := TBitMap.Create;
dt_hovered := TBitMap.Create;
dt_pressed := TBitMap.Create;

ofdm_normal := TBitMap.Create;
ofdm_hovered := TBitMap.Create;
ofdm_pressed := TBitMap.Create;

qam_auto_normal := TBitMap.Create;
qam_auto_hovered := TBitMap.Create;
qam_auto_pressed := TBitMap.Create;

qam_manual_normal := TBitMap.Create;
qam_manual_hovered := TBitMap.Create;
qam_manual_pressed := TBitMap.Create;

spectrum_normal := TBitMap.Create;
spectrum_hovered := TBitMap.Create;
spectrum_pressed := TBitMap.Create;

cdf_normal := TBitMap.Create;
cdf_hovered := TBitMap.Create;
cdf_pressed := TBitMap.Create;

dt_normal.LoadFromResourceName(HINSTANCE, 'dt_normal');
dt_hovered.LoadFromResourceName(HINSTANCE, 'dt_hovered');
dt_pressed.LoadFromResourceName(HINSTANCE, 'dt_pressed');

ofdm_normal.LoadFromResourceName(HINSTANCE, 'ofdm_normal');
ofdm_hovered.LoadFromResourceName(HINSTANCE, 'ofdm_hovered');
ofdm_pressed.LoadFromResourceName(HINSTANCE, 'ofdm_pressed');

qam_auto_normal.LoadFromResourceName(HINSTANCE, 'qam_auto_normal');
qam_auto_hovered.LoadFromResourceName(HINSTANCE, 'qam_auto_hovered');
qam_auto_pressed.LoadFromResourceName(HINSTANCE, 'qam_auto_pressed');

qam_manual_normal.LoadFromResourceName(HINSTANCE, 'qam_manual_normal');
qam_manual_hovered.LoadFromResourceName(HINSTANCE, 'qam_manual_hovered');
qam_manual_pressed.LoadFromResourceName(HINSTANCE, 'qam_manual_pressed');

spectrum_normal.LoadFromResourceName(HINSTANCE, 'spectrum_normal');
spectrum_hovered.LoadFromResourceName(HINSTANCE, 'spectrum_hovered');
spectrum_pressed.LoadFromResourceName(HINSTANCE, 'spectrum_pressed');

cdf_normal.LoadFromResourceName(HINSTANCE, 'cdf_normal');
cdf_hovered.LoadFromResourceName(HINSTANCE, 'cdf_hovered');
cdf_pressed.LoadFromResourceName(HINSTANCE, 'cdf_pressed');

//Image7.Picture.LoadFromFile(ExtractFileDir(Application.ExeName)+ '\screen\spectrum_screenshot.jpg');
Image1.Picture.Bitmap.Assign(dt_normal);
Image2.Picture.Bitmap.Assign(ofdm_normal);
Image3.Picture.Bitmap.Assign(qam_auto_normal);
Image4.Picture.Bitmap.Assign(qam_manual_normal);
Image5.Picture.Bitmap.Assign(spectrum_normal);
Image6.Picture.Bitmap.Assign(cdf_normal);
//showMessage(IntToStr(GetLastError()));
end;

procedure TForm8.Image1Click(Sender: TObject);
begin
//

end;

procedure TForm8.Image1MouseDown(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
Image1.Picture.Bitmap.Assign(dt_pressed);
end;

procedure TForm8.Image1MouseEnter(Sender: TObject);
begin
Image1.Picture.Bitmap.Assign(dt_hovered);

Memo1.Lines.Add('Данная программа позволяет пронаблюдать работу Дельта-Модулятора');

end;

procedure TForm8.Image1MouseLeave(Sender: TObject);
begin
Memo1.Clear;
Image1.Picture.Bitmap.Assign(dt_normal);
end;

procedure TForm8.Image1MouseUp(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
Image1.Picture.Bitmap.Assign(dt_normal);
end;

procedure TForm8.Image2Click(Sender: TObject);
begin
//
end;

procedure TForm8.Image2MouseDown(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
//
Image2.Picture.Bitmap.Assign(ofdm_pressed);
end;

procedure TForm8.Image2MouseEnter(Sender: TObject);
begin
Image2.Picture.Bitmap.Assign(ofdm_hovered);

Memo1.Lines.Add('Данная программа позволяет наблюдать как формируется OFDM сигнал и его состовляющие');

end;

procedure TForm8.Image2MouseLeave(Sender: TObject);
begin
//
Memo1.Clear;
Image2.Picture.Bitmap.Assign(ofdm_normal);
end;

procedure TForm8.Image2MouseUp(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
//
Image2.Picture.Bitmap.Assign(ofdm_normal);
end;

procedure TForm8.Image3MouseDown(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
//
Image3.Picture.Bitmap.Assign(qam_auto_pressed);
end;

procedure TForm8.Image3MouseEnter(Sender: TObject);
begin
//
Image3.Picture.Bitmap.Assign(qam_auto_hovered);

Memo1.Lines.Add('Данная программа позволяет наблюдать за тем, как программа строит сигнальное созвездие, в зависимости от входного потока');

end;

procedure TForm8.Image3MouseLeave(Sender: TObject);
begin
 //
 Memo1.Clear;
Image3.Picture.Bitmap.Assign(qam_auto_normal);
end;

procedure TForm8.Image3MouseUp(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
//
Image3.Picture.Bitmap.Assign(qam_auto_normal);
end;

procedure TForm8.Image4MouseDown(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
Image4.Picture.Bitmap.Assign(qam_manual_pressed);
end;

procedure TForm8.Image4MouseEnter(Sender: TObject);
begin//
Image4.Picture.Bitmap.Assign(qam_manual_hovered);

Memo1.Lines.Add('Данная программа позволяет управлять синфазной и квадратурной состовляющие и смотреть как будет выглядеть сигнал');

end;

procedure TForm8.Image4MouseLeave(Sender: TObject);
begin
 Memo1.Clear;
Image4.Picture.Bitmap.Assign(qam_manual_normal);
end;

procedure TForm8.Image4MouseUp(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
Image4.Picture.Bitmap.Assign(qam_manual_normal);
end;

procedure TForm8.Image5MouseDown(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
Image5.Picture.Bitmap.Assign(spectrum_pressed);
end;

procedure TForm8.Image5MouseEnter(Sender: TObject);
begin
Image5.Picture.Bitmap.Assign(spectrum_hovered);

Memo1.Lines.Add('Данная программа позволяет установить взаимосвязь между временным и спекральным представлением сигнала.');

end;

procedure TForm8.Image5MouseLeave(Sender: TObject);
begin
 Memo1.Clear;
Image5.Picture.Bitmap.Assign(spectrum_normal);
end;

procedure TForm8.Image5MouseUp(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
Image5.Picture.Bitmap.Assign(spectrum_normal);
end;

procedure TForm8.Image6MouseDown(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
Image6.Picture.Bitmap.Assign(cdf_pressed);
end;

procedure TForm8.Image6MouseEnter(Sender: TObject);
begin
Image6.Picture.Bitmap.Assign(cdf_hovered);

Memo1.Lines.Add('Данная программа посмотреть некоторые сигнальные созвездия, и как они интерпретирует ту или иную комбинацию на входе.');

end;

procedure TForm8.Image6MouseLeave(Sender: TObject);
begin
 Memo1.Clear;
Image6.Picture.Bitmap.Assign(cdf_normal);
end;

procedure TForm8.Image6MouseUp(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
Image6.Picture.Bitmap.Assign(cdf_normal);
end;

end.
