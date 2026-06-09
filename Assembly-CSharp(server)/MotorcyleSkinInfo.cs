using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001BB RID: 443
[Token(Token = "0x20001BB")]
public class MotorcyleSkinInfo : VehicleSkinInfoBase
{
	// Token: 0x1700009F RID: 159
	// (get) Token: 0x0600094E RID: 2382 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700009F")]
	public override Transform BodyModel
	{
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x228FF1C", Offset = "0x228FF1C", VA = "0x7BBCA8FF1C", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x0600094F RID: 2383 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000A0")]
	public override List<Transform> WheelModels
	{
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x228FF24", Offset = "0x228FF24", VA = "0x7BBCA8FF24", Slot = "5")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000950")]
	[Address(RVA = "0x2290004", Offset = "0x2290004", VA = "0x7BBCA90004", Slot = "6")]
	public override void SetSkinState(bool is_show)
	{
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000951")]
	[Address(RVA = "0x22902D8", Offset = "0x22902D8", VA = "0x7BBCA902D8", Slot = "7")]
	public override void ClearSkinAttached()
	{
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000952")]
	[Address(RVA = "0x2290584", Offset = "0x2290584", VA = "0x7BBCA90584", Slot = "8")]
	public override void EnableBrakeLightsEffect(bool enable)
	{
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000953")]
	[Address(RVA = "0x229064C", Offset = "0x229064C", VA = "0x7BBCA9064C")]
	public MotorcyleSkinInfo()
	{
	}

	// Token: 0x040008D3 RID: 2259
	[Token(Token = "0x40008D3")]
	[FieldOffset(Offset = "0x20")]
	public Transform MotorcyleBodyModel;

	// Token: 0x040008D4 RID: 2260
	[Token(Token = "0x40008D4")]
	[FieldOffset(Offset = "0x28")]
	public Transform VehicleBrakeLight;

	// Token: 0x040008D5 RID: 2261
	[Token(Token = "0x40008D5")]
	[FieldOffset(Offset = "0x30")]
	public Transform FrontWheelModel;

	// Token: 0x040008D6 RID: 2262
	[Token(Token = "0x40008D6")]
	[FieldOffset(Offset = "0x38")]
	public Transform RearWheelModel;

	// Token: 0x040008D7 RID: 2263
	[Token(Token = "0x40008D7")]
	[FieldOffset(Offset = "0x40")]
	public Transform FenderModel;

	// Token: 0x040008D8 RID: 2264
	[Token(Token = "0x40008D8")]
	[FieldOffset(Offset = "0x48")]
	public Transform SteerHandleModel;

	// Token: 0x040008D9 RID: 2265
	[Token(Token = "0x40008D9")]
	[FieldOffset(Offset = "0x50")]
	protected List<Transform> m_WheelModels;
}
