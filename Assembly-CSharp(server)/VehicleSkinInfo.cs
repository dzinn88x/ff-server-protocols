using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C2 RID: 450
[Token(Token = "0x20001C2")]
public class VehicleSkinInfo : VehicleSkinInfoBase
{
	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x06000988 RID: 2440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B0")]
	public override Transform BodyModel
	{
		[Token(Token = "0x6000988")]
		[Address(RVA = "0x218C1D8", Offset = "0x218C1D8", VA = "0x7BBC98C1D8", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x06000989 RID: 2441 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B1")]
	public override List<Transform> WheelModels
	{
		[Token(Token = "0x6000989")]
		[Address(RVA = "0x218C1E0", Offset = "0x218C1E0", VA = "0x7BBC98C1E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098A")]
	[Address(RVA = "0x218C3E8", Offset = "0x218C3E8", VA = "0x7BBC98C3E8", Slot = "6")]
	public override void SetSkinState(bool is_show)
	{
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098B")]
	[Address(RVA = "0x218C654", Offset = "0x218C654", VA = "0x7BBC98C654", Slot = "7")]
	public override void ClearSkinAttached()
	{
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098C")]
	[Address(RVA = "0x218C8A0", Offset = "0x218C8A0", VA = "0x7BBC98C8A0", Slot = "8")]
	public override void EnableBrakeLightsEffect(bool enable)
	{
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098D")]
	[Address(RVA = "0x218C968", Offset = "0x218C968", VA = "0x7BBC98C968")]
	public VehicleSkinInfo()
	{
	}

	// Token: 0x040008E7 RID: 2279
	[Token(Token = "0x40008E7")]
	[FieldOffset(Offset = "0x20")]
	public Transform VehicleBodyModel;

	// Token: 0x040008E8 RID: 2280
	[Token(Token = "0x40008E8")]
	[FieldOffset(Offset = "0x28")]
	public Transform VehicleBrakeLight;

	// Token: 0x040008E9 RID: 2281
	[Token(Token = "0x40008E9")]
	[FieldOffset(Offset = "0x30")]
	public Transform VehicleSteeringWheel;

	// Token: 0x040008EA RID: 2282
	[Token(Token = "0x40008EA")]
	[FieldOffset(Offset = "0x38")]
	public Transform FrontLeftWheelModel;

	// Token: 0x040008EB RID: 2283
	[Token(Token = "0x40008EB")]
	[FieldOffset(Offset = "0x40")]
	public Transform FrontRightWheelModel;

	// Token: 0x040008EC RID: 2284
	[Token(Token = "0x40008EC")]
	[FieldOffset(Offset = "0x48")]
	public Transform RearLeftWheelModel;

	// Token: 0x040008ED RID: 2285
	[Token(Token = "0x40008ED")]
	[FieldOffset(Offset = "0x50")]
	public Transform RearRightWheelModel;

	// Token: 0x040008EE RID: 2286
	[Token(Token = "0x40008EE")]
	[FieldOffset(Offset = "0x58")]
	private List<Transform> m_WheelModels;
}
