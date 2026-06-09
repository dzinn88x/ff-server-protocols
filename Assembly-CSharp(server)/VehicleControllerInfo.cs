using System;
using Il2CppDummyDll;

// Token: 0x020001BD RID: 445
[Token(Token = "0x20001BD")]
public class VehicleControllerInfo
{
	// Token: 0x06000956 RID: 2390 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000956")]
	[Address(RVA = "0x218BD68", Offset = "0x218BD68", VA = "0x7BBC98BD68")]
	public VehicleControllerInfo Clone()
	{
		return null;
	}

	// Token: 0x06000957 RID: 2391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000957")]
	[Address(RVA = "0x218BEF4", Offset = "0x218BEF4", VA = "0x7BBC98BEF4")]
	public VehicleControllerInfo()
	{
	}

	// Token: 0x040008DB RID: 2267
	[Token(Token = "0x40008DB")]
	[FieldOffset(Offset = "0x10")]
	public int WheelTypeChoise;

	// Token: 0x040008DC RID: 2268
	[Token(Token = "0x40008DC")]
	[FieldOffset(Offset = "0x14")]
	public float maxEngineRPM;

	// Token: 0x040008DD RID: 2269
	[Token(Token = "0x40008DD")]
	[FieldOffset(Offset = "0x18")]
	public float minEngineRPM;

	// Token: 0x040008DE RID: 2270
	[Token(Token = "0x40008DE")]
	[FieldOffset(Offset = "0x1C")]
	public float engineTorque;

	// Token: 0x040008DF RID: 2271
	[Token(Token = "0x40008DF")]
	[FieldOffset(Offset = "0x20")]
	public float brakeTorque;

	// Token: 0x040008E0 RID: 2272
	[Token(Token = "0x40008E0")]
	[FieldOffset(Offset = "0x24")]
	public float gearShiftingDelay;

	// Token: 0x040008E1 RID: 2273
	[Token(Token = "0x40008E1")]
	[FieldOffset(Offset = "0x28")]
	public float maxspeed;

	// Token: 0x040008E2 RID: 2274
	[Token(Token = "0x40008E2")]
	[FieldOffset(Offset = "0x2C")]
	public float defMaxspeed;

	// Token: 0x040008E3 RID: 2275
	[Token(Token = "0x40008E3")]
	[FieldOffset(Offset = "0x30")]
	public float idleBrakeInput;

	// Token: 0x040008E4 RID: 2276
	[Token(Token = "0x40008E4")]
	[FieldOffset(Offset = "0x34")]
	public float highSpeedSteerAngle;

	// Token: 0x040008E5 RID: 2277
	[Token(Token = "0x40008E5")]
	[FieldOffset(Offset = "0x38")]
	public float highSpeedSteerAngleAtSpeed;
}
