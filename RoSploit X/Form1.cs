﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RoSploit_X
{
    public partial class Form1 : Form
    {
        Timer time = new Timer();
        public Form1()
        {
            InitializeComponent();
            time.Tick += timertick;
            time.Start();
            ForlornApi.Api.InitializeForlorn();
        }

        private void timertick(object sender, EventArgs e)
        {
            if (ForlornApi.Api.IsRobloxOpen())
            {
                robloxopen.Text = "Roblox Open: ✅ Yes";
                robloxopen.ForeColor = Color.Green;  // Change text color to green
            }
            else
            {
                robloxopen.Text = "Roblox Open: ❌ No";
                robloxopen.ForeColor = Color.Red;  // Change text color to red
            }

            if (ForlornApi.Api.IsInjected())
            {
                status.Text = "Status: Injected";
                status.ForeColor = Color.Green;  // Change text color to green
            }
            else
            {
                status.Text = "Status: Not Injected";
                status.ForeColor = Color.Red;  // Change text color to red
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.ExecuteScript(fastColoredTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.Inject();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
        }

        private void IYButton_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet(('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'),true))()";
            ForlornApi.Api.ExecuteScript(fastColoredTextBox1.Text);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.KillRoblox();
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            fastColoredTextBox1.Text = "([[This file was protected with MoonSec V3]]):gsub('.+', (function(a) _PjpzssZszsXH = a; end)); return(function(h,...)local r;local o;local t;local s;local d;local a;local e=24915;local n=0;local l={};while n<220 do n=n+1;while n<0x125 and e%0x1dee<0xef7 do n=n+1 e=(e-604)%27883 local f=n+e if(e%0xa32)>=0x519 then e=(e-0x2e5)%0x17ff while n<0x17a and e%0x1cda<0xe6d do n=n+1 e=(e+884)%44760 local d=n+e if(e%0x140c)>=0xa06 then e=(e+0x1dd)%0x8849 local e=18203 if not l[e]then l[e]=0x1 t=(not t)and _ENV or t;end elseif e%2~=0 then e=(e*0x22c)%0x7467 local e=83174 if not l[e]then l[e]=0x1 s=tonumber;end else e=(e+0x247)%0x3f4d n=n+1 local e=42865 if not l[e]then l[e]=0x1 t=getfenv and getfenv();end end end elseif e%2~=0 then e=(e*0x137)%0x99e8 while n<0x325 and e%0x1f26<0xf93 do n=n+1 e=(e*491)%27484 local t=n+e if(e%0x35c6)>=0x1ae3 then e=(e-0x1c8)%0x7035 local e=62101 if not l[e]then l[e]=0x1 a=string;end elseif e%2~=0 then e=(e+0x27a)%0x3190 local e=30827 if not l[e]then l[e]=0x1 o={};end else e=(e-0x1c1)%0x115d n=n+1 local e=19289 if not l[e]then l[e]=0x1 end end end else e=(e*0x2df)%0x54c7 n=n+1 while n<0x1f7 and e%0x4622<0x2311 do n=n+1 e=(e-944)%39787 local f=n+e if(e%0x4d9c)<0x26ce then e=(e*0x1c6)%0x894d local e=22331 if not l[e]then l[e]=0x1 d=function(d)local e=0x01 local function l(n)e=e+n return d:sub(e-n,e-0x01)end while true do local n=l(0x01)if(n==\"\\5\")then break end local e=a.byte(l(0x01))local e=l(e)if n==\"\\2\"then e=o.sApvpDSf(e)elseif n==\"\\3\"then e=e~=\"\\0\"elseif n==\"\\6\"then t[e]=function(e,n)return h(8,nil,h,n,e)end elseif n==\"\\4\"then e=t[e]elseif n==\"\\0\"then e=t[e][l(a.byte(l(0x01)))];end local n=l(0x08)o[n]=e end end end elseif e%2~=0 then e=(e*0x115)%0x87b8 local e=59272 if not l[e]then l[e]=0x1 r=\"\\4\\8\\116\\111\\110\\117\\109\\98\\101\\114\\115\\65\\112\\118\\112\\68\\83\\102\\0\\6\\115\\116\\114\\105\\110\\103\\4\\99\\104\\97\\114\\86\\120\\121\\72\\97\\87\\77\\116\\0\\6\\115\\116\\114\\105\\110\\103\\3\\115\\117\\98\\79\\116\\116\\115\\114\\82\\107\\121\\0\\6\\115\\116\\114\\105\\110\\103\\4\\98\\121\\116\\101\\115\\113\\83\\100\\68\\97\\116\\65\\0\\5\\116\\97\\98\\108\\101\\6\\99\\111\\110\\99\\97\\116\\82\\81\\72\\81\\107\\120\\73\\118\\0\\5\\116\\97\\98\\108\\101\\6\\105\\110\\115\\101\\114\\116\\82\\98\\114\\67\\103\\74\\82\\79\\5\";end else e=(e+0x174)%0x4c33 n=n+1 local e=11855 if not l[e]then l[e]=0x1 end end end end end e=(e+533)%10616 end d(r);local n={};for e=0x0,0xff do local l=o.VxyHaWMt(e);n[e]=l;n[l]=e;end local function c(e)return n[e];end local a=(function(r,d)local f,l=0x01,0x10 local n={{},{},{}}local t=-0x01 local e=0x01 local a=r while true do n[0x03][o.OttsrRky(d,e,(function()e=f+e return e-0x01 end)())]=(function()t=t+0x01 return t end)()if t==(0x0f)then t=\"\"l=0x000 break end end local t=#d while e<t+0x01 do n[0x02][l]=o.OttsrRky(d,e,(function()e=f+e return e-0x01 end)())l=l+0x01 if l%0x02==0x00 then l=0x00 o.RbrCgJRO(n[0x01],(c((((n[0x03][n[0x02][0x00]]or 0x00)*0x10)+(n[0x03][n[0x02][0x01]]or 0x00)+a)%0x100)));a=r+a;end end return o.RQHQkxIv(n[0x01])end);d(a(165,\"#M=Xs/Ny&fzwL7h(NV\"));d(a(248,\"N41Dla0{},RIj_&A(}40}I,l,R,,R0R{ljIlj_j__}_A&&&&_,_1B4A1&IIlI_DT1ID4llljDDa_aAallR{}}R,D1,DaR}I1I4I&jj_0_4&,II_R&j_Av,RuR&1D1jD1D4D&DA&aaaa40j0D{30,}A,l,,}},<R&Iaawajj_j,&l&J}aAlAlA_4}4}Yl44Vl4jDR1_l1DAAlQl{D0_}l}a}a,j,4RjR4RRIjI_jIjR_DII&aA0A4A{RlRAq04_1DDjDAlR4DaI0DDAa}{L0A}_{D1jDlRAR4I4jlRjIQ_lI{j,j0_QAD,RR4&4A{D1Lj44l}D4laD{Al o{l{{}D}j,1,4,&,AI0IDR},&RRjBjl&l}m}_WlA,/14l4aI&DaD0l9D,lDaD00D&l,lA0D{4}j,RDlD&IaI0jKI,jD_D&0jIjA_lA_&a&D11IlI_DJDRD,l0alD{l1l4l1lA0l{j}01jD0RIRaIlIaII_lj,&R&lj}AI.}AAxjR}Il1a14DjD}__l0alaA0{{1a}a}0}{1{AR},4Rjl_\"));local e=(-3226+(function()local t,n=0,1;(function(e,t,l,n)e(e(e,n and e,t,n),n(t,e,t,e),e(l,e and l,l,l),l(l,t and n,n,n))end)(function(l,d,o,e)if t>221 then return l end t=t+1 n=(n+728)%30398 if(n%980)<490 then return e(o(e,l,d and o,d),e(e and o,e and e,d,l),d(d,l and d,l and o,e and l),e(l,o,l and d,l))else return e end return o end,function(l,d,e,o)if t>281 then return l end t=t+1 n=(n-47)%14066 if(n%1568)<=784 then n=(n*832)%16668 return d(o(e,d,d,d)and l(l,o,d and l,e),e(o,o,l,l),l(o,e,e,o)and e(d,o,e,l),e(l,d and l,d,e))else return e end return d end,function(o,e,l,d)if t>464 then return d end t=t+1 n=(n+449)%17990 if(n%1842)>=921 then return l(d(e,d,d,e),d(e,o,l,e),o(e,e,o,l),e(l,e,e,l and l))else return d end return o end,function(d,e,l,o)if t>236 then return e end t=t+1 n=(n-846)%28393 if(n%1738)<869 then n=(n+694)%37714 return l else return d(d(e,d,l,e),e(o,l,o,l),d(o and o,d,l,l and e),l(e,d,o,e))end return e(d(e,o,e,e),e(d and o,l,e,d),d(e,o and e,l,l),d(e,l,e,l))end)return n;end)())local f=o.vSOLmMCz or o.vFIGSYlr;local z=(getfenv)or(function()return _ENV end);local p=1;local t=2;local u=4;local d=3;local function b(k,...)local r=a(e,\"%)5?-(k/:QmOx_;X_XO&::k<?:)m;:x+Q:_xO/:)(x-?)xX5x)Q;kX;h_)Quk:-vk((X?/d;xOO(:O(X5O5-XmxQmk//(O3:P)_-mx:(kk)))xX-xm?y)(;1O:QHx/Q&:5kM-5)?;OmmQO/m-O :_^k>(X)w;:xU;x_:O)Q?):?k));xO_(j/X-)5OOU_:O5:/k-5_{?;xO(:x5R-X)QXxx:(:(_(/5X6kx?m_:?):5k_O:eQ;?a0:;a5Yt-_xOb:O5mX/xX;mO)QX5;?X)QXxx:m_/5(_??X_;5mO:Xkk--N_;;xx(;kO-X5(OX_Om):-(_?OI);-O_(Q?5DO_X!,_QO5:m-;?5X__(mxQ(k:?(_/;_OQQQ/kFX5(X)_OO-/_k5x:m-/:(H5:k/?Q)_;_kH?X)E;:xZ;g;-OxQe?X?()x:X(:?nK:;#x/QBk:-,)QX8x:m*:mk 5:&}_:O5::ko?:55X_xJQ:/>-O5nX:_Bx;:-(:?w+:;kO:Q)k:--):X-xXmc/:(,5;Ys_QOB:xk/?:)i;:x/Q:/)-:54r:_ m::0(Q?wj:;TxmQ)k:-3):X)x:mP/:k5?xuV_QO2:;kW?:)oH:_2Q:/)-:5)X:_/m:Q5k-?lFO;yO_QKk:-}):hQx:m)/:(?5:4=_:OYQ{kE?:)!;:x6Qm/V-:?!X:_!m::)(:?)A:;dxOQ&k:-P)QX,x:m7/:(C5:Sg_:\");local n=0;o.KmgTBhrs(function()o.TPlGQFHc()n=n+1 end)local function e(e,l)if l then return n end;n=e+n;end local l,n,c=h(0,h,e,r,o.sqSdDatA);local function a()local l,n=o.sqSdDatA(r,e(1,3),e(5,6)+2);e(2);return(n*256)+l;end;local _=true;local _=0 local function j()local e=n();local n=n();local d=1;local t=(l(n,1,20)*(2^32))+e;local e=l(n,21,31);local n=((-1)^l(n,32));if(e==0)then if(t==_)then return n*0;else e=1;d=0;end;elseif(e==2047)then return(t==0)and(n*(1/0))or(n*(0/0));end;return o.TYDTjUbW(n,e-1023)*(d+(t/(2^52)));end;local m=n;local function y(n)local l;if(not n)then n=m();if(n==0)then return'';end;end;l=o.OttsrRky(r,e(1,3),e(5,6)+n-1);e(n)local e=\"\"for n=(1+_),#l do e=e..o.OttsrRky(l,n,n)end return e;end;local m=#o.vkXFJXTl(s('\\49.\\48'))~=1 local e=n;local function ee(...)return{...},o.azlHsxgl('#',...)end local function b()local h={};local _={};local e={};local s={_,h,nil,e};local e=n()local r={}for t=1,e do local l=c();local n;if(l==1)then n=(c()~=#{});elseif(l==2)then local e=j();if m and o.YwtqXXnm(o.vkXFJXTl(e),'.(\\48+)$')then e=o.PHPRWxYl(e);end n=e;elseif(l==0)then n=y();end;r[t]=n;end;for h=1,n()do local e=c();if(l(e,1,1)==0)then local o=l(e,2,3);local f=l(e,4,6);local e={a(),a(),nil,nil};if(o==0)then e[d]=a();e[u]=a();elseif(o==#{1})then e[d]=n();elseif(o==k[2])then e[d]=n()-(2^16)elseif(o==k[3])then e[d]=n()-(2^16)e[u]=a();end;if(l(f,1,1)==1)then e[t]=r[e[t]]end if(l(f,2,2)==1)then e[d]=r[e[d]]end if(l(f,3,3)==1)then e[u]=r[e[u]]end _[h]=e;end end;s[3]=c();for e=1,n()do h[e-(#{1})]=b();end;return s;end;local function y(l,e,n)local t=e;local t=n;return s(o.YwtqXXnm(o.YwtqXXnm(({o.KmgTBhrs(l)})[2],e),n))end local function g(j,e,c)local function ne(...)local r,g,k,z,s,l,a,b,m,_,y,n;local e=0;while-1<e do if 3>e then if e>=1 then if-2~=e then for n=23,74 do if e<2 then k=h(6,32,3,46,j);s=ee z=0;break;end;l=-41;a=-1;break;end;else l=-41;a=-1;end else r=h(6,95,1,14,j);g=h(6,28,2,75,j);end else if 5>e then if 1~=e then for n=29,87 do if 4>e then b={};m={...};break;end;_=o.azlHsxgl('#',...)-1;y={};break;end;else _=o.azlHsxgl('#',...)-1;y={};end else if 5==e then n=h(7);else e=-2;end end end e=e+1;end;for e=0,_ do if(e>=k)then b[e-k]=m[e+1];else n[e]=m[e+1];end;end;local e=_-k+1 local e;local o;local function h(...)while true do end end while true do if l<-40 then l=l+42 end e=r[l];o=e[p];if 11<o then if o<=17 then if 15<=o then if 15>=o then for o=0,3 do if 1<o then if o~=-2 then for a=48,53 do if 2<o then if(n[e[t]]==e[u])then l=l+1;else l=e[d];end;break;end;n[e[t]]=c[e[d]];l=l+1;e=r[l];break;end;else n[e[t]]=c[e[d]];l=l+1;e=r[l];end else if o>-4 then repeat if 1~=o then n[e[t]]=(e[d]~=0);l=l+1;e=r[l];break;end;c[e[d]]=n[e[t]];l=l+1;e=r[l];until true;else c[e[d]]=n[e[t]];l=l+1;e=r[l];end end end else if o>12 then repeat if o~=17 then do return end;break;end;local e=e[t]n[e]=n[e](f(n,e+1,a))until true;else do return end;end end else if 12>=o then local l=e[t]local t,e=s(n[l](f(n,l+1,e[d])))a=e+l-1 local e=0;for l=l,a do e=e+1;n[l]=t[e];end;else if 9<=o then repeat if o>13 then local l=e[t]local t,e=s(n[l](f(n,l+1,e[d])))a=e+l-1 local e=0;for l=l,a do e=e+1;n[l]=t[e];end;break;end;n[e[t]]();until true;else local l=e[t]local t,e=s(n[l](f(n,l+1,e[d])))a=e+l-1 local e=0;for l=l,a do e=e+1;n[l]=t[e];end;end end end else if 20>=o then if 19>o then c[e[d]]=n[e[t]];else if o~=19 then local o,_,j,k,h;n[e[t]]=c[e[d]];l=l+1;e=r[l];o=e[t];_=n[e[d]];n[o+1]=_;n[o]=_[e[u]];l=l+1;e=r[l];n(e[t],e[d]);l=l+1;e=r[l];o=e[t]j,k=s(n[o](f(n,o+1,e[d])))a=k+o-1 h=0;for e=o,a do h=h+1;n[e]=j[h];end;l=l+1;e=r[l];o=e[t]n[o]=n[o](f(n,o+1,a))l=l+1;e=r[l];n[e[t]]();l=l+1;e=r[l];do return end;else l=e[d];end end else if o<=21 then if(n[e[t]]==e[u])then l=l+1;else l=e[d];end;else if 20~=o then repeat if 22~=o then if(n[e[t]]==e[u])then l=l+1;else l=e[d];end;break;end;n[e[t]]=(e[d]~=0);until true;else n[e[t]]=(e[d]~=0);end end end end else if 5>=o then if 2>=o then if o<=0 then do return end;else if o>-3 then for l=27,75 do if 1~=o then local a,o,c,r,f;local l=0;while l>-1 do if l>=3 then if 4>=l then if 3~=l then f=a[o];else r=a[c];end else if 6==l then l=-2;else n(f,r);end end else if l<1 then a=e;else if l>0 then for e=12,70 do if l~=2 then o=t;break;end;c=d;break;end;else o=t;end end end l=l+1 end break;end;n[e[t]]=c[e[d]];break;end;else n[e[t]]=c[e[d]];end end else if o<=3 then n(e[t],e[d]);else if 1~=o then repeat if 4<o then c[e[d]]=n[e[t]];break;end;n[e[t]]=(e[d]~=0);until true;else n[e[t]]=(e[d]~=0);end end end else if o<=8 then if o<=6 then n[e[t]]=c[e[d]];else if o<8 then l=e[d];else local l=e[t];local t=n[e[d]];n[l+1]=t;n[l]=t[e[u]];end end else if o>9 then if 6~=o then repeat if o~=11 then n[e[t]]();break;end;local e=e[t]n[e]=n[e](f(n,e+1,a))until true;else local e=e[t]n[e]=n[e](f(n,e+1,a))end else local t=e[t];local l=n[e[d]];n[t+1]=l;n[t]=l[e[u]];end end end end l=1+l;end;end;return ne end;local d=0xff;local c={};local a=(1);local t='';(function(n)local l=n local r=0x00 local e=0x00 l={(function(f)if r>0x2e then return f end r=r+1 e=(e+0xd73-f)%0x22 return(e%0x03==0x0 and(function(l)if not n[l]then e=e+0x01 n[l]=(0xb);end return true end)'MwEXf'and l[0x1](0x2ef+f))or(e%0x03==0x2 and(function(l)if not n[l]then e=e+0x01 n[l]=(0x94);c[a]=z();a=a+d;end return true end)'TOgbf'and l[0x2](f+0x368))or(e%0x03==0x1 and(function(l)if not n[l]then e=e+0x01 n[l]=(0xe);t={t..'\\58 a',t};c[a]=b();a=a+((not o.ovnQBiRC)and 1 or 0);t[1]='\\58'..t[1];d[2]=0xff;end return true end)'mJLRk'and l[0x3](f+0x3c0))or f end),(function(o)if r>0x1e then return o end r=r+1 e=(e+0x957-o)%0x2e return(e%0x03==0x0 and(function(l)if not n[l]then e=e+0x01 n[l]=(0xeb);end return true end)'ocvtz'and l[0x2](0x187+o))or(e%0x03==0x1 and(function(l)if not n[l]then e=e+0x01 n[l]=(0x11);end return true end)'_id_C'and l[0x3](o+0x3e3))or(e%0x03==0x2 and(function(l)if not n[l]then e=e+0x01 n[l]=(0x54);t='\\37';d={function()d()end};t=t..'\\100\\43';end return true end)'VMGwp'and l[0x1](o+0x2e6))or o end),(function(o)if r>0x29 then return o end r=r+1 e=(e+0x1192-o)%0x23 return(e%0x03==0x2 and(function(l)if not n[l]then e=e+0x01 n[l]=(0xbb);end return true end)'TOttQ'and l[0x2](0x123+o))or(e%0x03==0x1 and(function(l)if not n[l]then e=e+0x01 n[l]=(0x30);d[2]=(d[2]*(y(function()c()end,f(t))-y(d[1],f(t))))+1;c[a]={};d=d[2];a=a+d;end return true end)'YkiZY'and l[0x1](o+0xf8))or(e%0x03==0x0 and(function(l)if not n[l]then e=e+0x01 n[l]=(0xe1);end return true end)'cikyy'and l[0x3](o+0x3d8))or o end)}l[0x2](0x1289)end){};local e=g(f(c));return e(...);end return b((function()local n={}local e=0x01;local l;if o.ovnQBiRC then l=o.ovnQBiRC(b)else l=''end if o.YwtqXXnm(l,o.viyCZdOq)then e=e+0;else e=e+1;end n[e]=0x02;n[n[e]+0x01]=0x03;return n;end)(),...)end)((function(e,n,l,d,t,o)local o;if 3>=e then if e>=2 then if 2==e then do return 16777216,65536,256 end;else do return n(1),n(4,t,d,l,n),n(5,t,d,l)end;end else if-1<e then repeat if 0<e then do return function(l,e,n)if n then local e=(l/2^(e-1))%2^((n-1)-(e-1)+1);return e-e%1;else local e=2^(e-1);return(l%(e+e)>=e)and 1 or 0;end;end;end;break;end;do return n(1),n(4,t,d,l,n),n(5,t,d,l)end;until true;else do return function(n,e,l)if l then local e=(n/2^(e-1))%2^((l-1)-(e-1)+1);return e-e%1;else local e=2^(e-1);return(n%(e+e)>=e)and 1 or 0;end;end;end;end end else if 6>e then if 2<e then for o=23,74 do if e~=4 then local e=d;do return function()local n=n(l,e(e,e),e(e,e));e(1);return n;end;end;break;end;local e=d;local t,o,d=t(2);do return function()local n,l,r,a=n(l,e(e,e),e(e,e)+3);e(4);return(a*t)+(r*o)+(l*d)+n;end;end;break;end;else local e=d;local r,o,a=t(2);do return function()local d,t,l,n=n(l,e(e,e),e(e,e)+3);e(4);return(n*r)+(l*o)+(t*a)+d;end;end;end else if e>6 then if 4~=e then repeat if 7<e then do return l(e,nil,l);end break;end;do return setmetatable({},{['__\\99\\97\\108\\108']=function(e,l,t,d,n)if n then return e[n]elseif d then return e else e[l]=t end end})end until true;else do return setmetatable({},{['__\\99\\97\\108\\108']=function(e,l,t,d,n)if n then return e[n]elseif d then return e else e[l]=t end end})end end else do return t[l]end;end end end end),...)";
            ForlornApi.Api.ExecuteScript(fastColoredTextBox1.Text);
        }

        private void SBScript_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet(\"https://scriptblox.com/raw/Slap-Battles-Open-source-for-9484\"))()";
            ForlornApi.Api.ExecuteScript(fastColoredTextBox1.Text);
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring('\\108\\111\\97\\100\\115\\116\\114\\105\\110\\103\\40\\103\\97\\109\\101\\58\\72\\116\\116\\112\\71\\101\\116\\40\\40\\39\\104\\116\\116\\112\\115\\58\\47\\47\\103\\105\\115\\116\\46\\103\\105\\116\\104\\117\\98\\117\\115\\101\\114\\99\\111\\110\\116\\101\\110\\116\\46\\99\\111\\109\\47\\109\\101\\111\\122\\111\\110\\101\\89\\84\\47\\98\\102\\48\\51\\55\\100\\102\\102\\57\\102\\48\\97\\55\\48\\48\\49\\55\\51\\48\\52\\100\\100\\100\\54\\55\\102\\100\\99\\100\\51\\55\\48\\47\\114\\97\\119\\47\\101\\49\\52\\101\\55\\52\\102\\52\\50\\53\\98\\48\\54\\48\\100\\102\\53\\50\\51\\51\\52\\51\\99\\102\\51\\48\\98\\55\\56\\55\\48\\55\\52\\101\\98\\51\\99\\53\\100\\50\\47\\97\\114\\99\\101\\117\\115\\37\\50\\53\\50\\48\\120\\37\\50\\53\\50\\48\\102\\108\\121\\37\\50\\53\\50\\48\\50\\37\\50\\53\\50\\48\\111\\98\\102\\108\\117\\99\\97\\116\\111\\114\\39\\41\\44\\116\\114\\117\\101\\41\\41\\40\\41\\10\\10')()";
            ForlornApi.Api.ExecuteScript(fastColoredTextBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet('https://pastebin.com/raw/LnXACG8L',true))()";
            ForlornApi.Api.ExecuteScript(fastColoredTextBox1.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}