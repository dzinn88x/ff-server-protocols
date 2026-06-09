using System;
using Il2CppDummyDll;

// Token: 0x020000B6 RID: 182
[Token(Token = "0x20000B6")]
public class RoomInfo : IEquatable<RoomInfo>
{
	// Token: 0x060002AD RID: 685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x23DDA54", Offset = "0x23DDA54", VA = "0x7BBCBDDA54")]
	public RoomInfo()
	{
	}

	// Token: 0x060002AE RID: 686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x23DDAB0", Offset = "0x23DDAB0", VA = "0x7BBCBDDAB0")]
	public RoomInfo(string roomID, string userID, string tag = "")
	{
	}

	// Token: 0x060002AF RID: 687 RVA: 0x000025B0 File Offset: 0x000007B0
	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x23DDB34", Offset = "0x23DDB34", VA = "0x7BBCBDDB34", Slot = "4")]
	public bool Equals(RoomInfo other)
	{
		return default(bool);
	}

	// Token: 0x040002E7 RID: 743
	[Token(Token = "0x40002E7")]
	[FieldOffset(Offset = "0x10")]
	public string RoomID;

	// Token: 0x040002E8 RID: 744
	[Token(Token = "0x40002E8")]
	[FieldOffset(Offset = "0x18")]
	public string UserID;

	// Token: 0x040002E9 RID: 745
	[Token(Token = "0x40002E9")]
	[FieldOffset(Offset = "0x20")]
	public string Tag;
}
