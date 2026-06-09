using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200201F RID: 8223
	[Token(Token = "0x200201F")]
	public class UIModelVehicleDisplay : UIBaseModel
	{
		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x0600B74E RID: 46926 RVA: 0x00034578 File Offset: 0x00032778
		// (set) Token: 0x0600B74F RID: 46927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CA6")]
		public uint SelectedVehicleSkinID
		{
			[Token(Token = "0x600B74E")]
			[Address(RVA = "0x14BC3F8", Offset = "0x14BC3F8", VA = "0x7BBBCBC3F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114781C", Offset = "0x114781C")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600B74F")]
			[Address(RVA = "0x14BC400", Offset = "0x14BC400", VA = "0x7BBBCBC400")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114782C", Offset = "0x114782C")]
			private set
			{
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x0600B750 RID: 46928 RVA: 0x00034590 File Offset: 0x00032790
		// (set) Token: 0x0600B751 RID: 46929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CA7")]
		public bool GetDataAfterLogin
		{
			[Token(Token = "0x600B750")]
			[Address(RVA = "0x14BC408", Offset = "0x14BC408", VA = "0x7BBBCBC408")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114783C", Offset = "0x114783C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B751")]
			[Address(RVA = "0x14BC410", Offset = "0x14BC410", VA = "0x7BBBCBC410")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114784C", Offset = "0x114784C")]
			private set
			{
			}
		}

		// Token: 0x0600B752 RID: 46930 RVA: 0x000345A8 File Offset: 0x000327A8
		[Token(Token = "0x600B752")]
		[Address(RVA = "0x14BC41C", Offset = "0x14BC41C", VA = "0x7BBBCBC41C", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B753 RID: 46931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B753")]
		[Address(RVA = "0x14BC424", Offset = "0x14BC424", VA = "0x7BBBCBC424", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B754 RID: 46932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B754")]
		[Address(RVA = "0x14BC450", Offset = "0x14BC450", VA = "0x7BBBCBC450")]
		public UIModelVehicleDisplay()
		{
		}

		// Token: 0x0400B973 RID: 47475
		[Token(Token = "0x400B973")]
		public const string HDVEHICLEDISPLAYGUIDE = "HDVEHICLEDISPLAYGUIDE_";

		// Token: 0x0400B974 RID: 47476
		[Token(Token = "0x400B974")]
		public const string UILobbyVehicleDisplayGuideKey = "UILOBBYVEHICLEDISPLAYGUIDEKEY_";

		// Token: 0x0400B975 RID: 47477
		[Token(Token = "0x400B975")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113080C", Offset = "0x113080C")]
		private uint <SelectedVehicleSkinID>k__BackingField;

		// Token: 0x0400B976 RID: 47478
		[Token(Token = "0x400B976")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113081C", Offset = "0x113081C")]
		private bool <GetDataAfterLogin>k__BackingField;
	}
}
