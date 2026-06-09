using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020011A1 RID: 4513
	[Token(Token = "0x20011A1")]
	public class VehicleSkinPropertyData : CSVBaseData
	{
		// Token: 0x0600463C RID: 17980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600463C")]
		[Address(RVA = "0x179A1F8", Offset = "0x179A1F8", VA = "0x7BBBF9A1F8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600463D RID: 17981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600463D")]
		[Address(RVA = "0x179A204", Offset = "0x179A204", VA = "0x7BBBF9A204", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600463E RID: 17982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600463E")]
		[Address(RVA = "0x179A594", Offset = "0x179A594", VA = "0x7BBBF9A594")]
		public VehicleSkinPropertyData()
		{
		}

		// Token: 0x04005764 RID: 22372
		[Token(Token = "0x4005764")]
		[FieldOffset(Offset = "0x10")]
		public uint SkinID;

		// Token: 0x04005765 RID: 22373
		[Token(Token = "0x4005765")]
		[FieldOffset(Offset = "0x14")]
		public uint VehicleID;

		// Token: 0x04005766 RID: 22374
		[Token(Token = "0x4005766")]
		[FieldOffset(Offset = "0x18")]
		public bool IsTaillight;

		// Token: 0x04005767 RID: 22375
		[Token(Token = "0x4005767")]
		[FieldOffset(Offset = "0x20")]
		public string HornAudioRes;

		// Token: 0x04005768 RID: 22376
		[Token(Token = "0x4005768")]
		[FieldOffset(Offset = "0x28")]
		public string StartSoundRes;

		// Token: 0x04005769 RID: 22377
		[Token(Token = "0x4005769")]
		[FieldOffset(Offset = "0x30")]
		public string ShiftSoundRes;

		// Token: 0x0400576A RID: 22378
		[Token(Token = "0x400576A")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, TssSdtFloat> Params;

		// Token: 0x0400576B RID: 22379
		[Token(Token = "0x400576B")]
		public const string PROPERTYTYPE_MAXSPEED = "max_speed";

		// Token: 0x0400576C RID: 22380
		[Token(Token = "0x400576C")]
		public const string PROPERTYTYPE_REDUCEDAMGE = "reduce_damage";

		// Token: 0x0400576D RID: 22381
		[Token(Token = "0x400576D")]
		public const string PROPERTYTYPE_HIGHTSPEEDANGLE = "high_speed_steerangle";

		// Token: 0x0400576E RID: 22382
		[Token(Token = "0x400576E")]
		public const string PROPERTYTYPE_ENGINETORQUE = "engine_torque";

		// Token: 0x0400576F RID: 22383
		[Token(Token = "0x400576F")]
		public const string PROPERTYTYPE_BRAKETORQUE = "brake_torque";

		// Token: 0x04005770 RID: 22384
		[Token(Token = "0x4005770")]
		public const string PROPERTYTYPE_BOOSTDURATION = "boost_duration";

		// Token: 0x04005771 RID: 22385
		[Token(Token = "0x4005771")]
		public const string PROPERTYTYPE_BOOSTCD = "boost_cd";

		// Token: 0x04005772 RID: 22386
		[Token(Token = "0x4005772")]
		public const string PROPERTYTYPE_JUMPHEIGHT = "jump_height";

		// Token: 0x04005773 RID: 22387
		[Token(Token = "0x4005773")]
		public const string PROPERTYTYPE_JUMPCD = "jump_cd";

		// Token: 0x04005774 RID: 22388
		[Token(Token = "0x4005774")]
		public const string PROPERTYTYPE_ENABLEMARK = "mark_leave";

		// Token: 0x04005775 RID: 22389
		[Token(Token = "0x4005775")]
		public const string PROPERTYTYPE_MESSFACTOR = "mess_factor";

		// Token: 0x04005776 RID: 22390
		[Token(Token = "0x4005776")]
		[FieldOffset(Offset = "0x0")]
		public static string[] PROPERTYTYPE_SHOWLIST;
	}
}
