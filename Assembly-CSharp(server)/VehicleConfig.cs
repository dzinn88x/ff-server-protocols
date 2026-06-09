using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B2 RID: 178
[Token(Token = "0x20000B2")]
public class VehicleConfig : MonoBehaviour
{
	// Token: 0x060002AA RID: 682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x218BD50", Offset = "0x218BD50", VA = "0x7BBC98BD50")]
	public VehicleConfig()
	{
	}

	// Token: 0x040002C1 RID: 705
	[Token(Token = "0x40002C1")]
	[FieldOffset(Offset = "0x18")]
	public EControlMode conrolMode;

	// Token: 0x040002C2 RID: 706
	[Token(Token = "0x40002C2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public VehicleConfig.CarCrashParam crashParam;

	// Token: 0x040002C3 RID: 707
	[Token(Token = "0x40002C3")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public VehicleConfig.CarExplodeParam ExplodeParam;

	// Token: 0x040002C4 RID: 708
	[Token(Token = "0x40002C4")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public CarInWaterParam InWaterParam;

	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x20000B3")]
	[Serializable]
	public class CarCrashParam
	{
		// Token: 0x060002AB RID: 683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x218BD58", Offset = "0x218BD58", VA = "0x7BBC98BD58")]
		public CarCrashParam()
		{
		}

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x10")]
		public float messFactor;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x10FFDA4", Offset = "0x10FFDA4")]
		public float maxSpeed;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x18")]
		public float minDamage;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x1C")]
		public float maxDamage;
	}

	// Token: 0x020000B4 RID: 180
	[Token(Token = "0x20000B4")]
	[Serializable]
	public class CarExplodeParam
	{
		// Token: 0x060002AC RID: 684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x218BD60", Offset = "0x218BD60", VA = "0x7BBC98BD60")]
		public CarExplodeParam()
		{
		}

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x10")]
		public float ExplodeDelay;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x14")]
		public float ExplodeRange;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x18")]
		public uint ExplodeDamage;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x1C")]
		public float BurnTime;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x20")]
		public BoxCollider BurnRange;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x28")]
		public uint BurnDamage;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x2C")]
		public float BurnInterval;
	}
}
