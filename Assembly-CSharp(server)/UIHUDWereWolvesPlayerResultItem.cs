using System;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000124 RID: 292
[Token(Token = "0x2000124")]
public class UIHUDWereWolvesPlayerResultItem : MonoBehaviour
{
	// Token: 0x17000047 RID: 71
	// (get) Token: 0x0600056C RID: 1388 RVA: 0x00002FB8 File Offset: 0x000011B8
	[Token(Token = "0x17000047")]
	public bool IsThumbUp
	{
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1CA949C", Offset = "0x1CA949C", VA = "0x7BBC4A949C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056D")]
	[Address(RVA = "0x1CA94A4", Offset = "0x1CA94A4", VA = "0x7BBC4A94A4")]
	public void InitShowData(ulong userID, {QAb\u0082~u playerID, string nickName, int roleColorIndex, bool isDead, bool isWolf, int taskOrKillCount)
	{
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056E")]
	[Address(RVA = "0x1CA9B90", Offset = "0x1CA9B90", VA = "0x7BBC4A9B90")]
	private void SetFriendBtnState()
	{
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056F")]
	[Address(RVA = "0x1CA9958", Offset = "0x1CA9958", VA = "0x7BBC4A9958")]
	private void SetPetIcon(int colorIndex)
	{
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000570")]
	[Address(RVA = "0x1CA9D40", Offset = "0x1CA9D40", VA = "0x7BBC4A9D40")]
	private void OnAddFriend()
	{
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000571")]
	[Address(RVA = "0x1CA9E80", Offset = "0x1CA9E80", VA = "0x7BBC4A9E80")]
	private void OnThumbUp()
	{
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000572")]
	[Address(RVA = "0x1CA9D08", Offset = "0x1CA9D08", VA = "0x7BBC4A9D08")]
	public void SetMicActive(bool isActive)
	{
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000573")]
	[Address(RVA = "0x1CA9F10", Offset = "0x1CA9F10", VA = "0x7BBC4A9F10")]
	public UIHUDWereWolvesPlayerResultItem()
	{
	}

	// Token: 0x0400049D RID: 1181
	[Token(Token = "0x400049D")]
	[FieldOffset(Offset = "0x18")]
	public UILabel IndexLabel;

	// Token: 0x0400049E RID: 1182
	[Token(Token = "0x400049E")]
	[FieldOffset(Offset = "0x20")]
	public UISprite IndexBg;

	// Token: 0x0400049F RID: 1183
	[Token(Token = "0x400049F")]
	[FieldOffset(Offset = "0x28")]
	public UISprite PetIcon;

	// Token: 0x040004A0 RID: 1184
	[Token(Token = "0x40004A0")]
	[FieldOffset(Offset = "0x30")]
	public UILabel NameLabel;

	// Token: 0x040004A1 RID: 1185
	[Token(Token = "0x40004A1")]
	[FieldOffset(Offset = "0x38")]
	public UISprite KillOrTaskSprite;

	// Token: 0x040004A2 RID: 1186
	[Token(Token = "0x40004A2")]
	[FieldOffset(Offset = "0x40")]
	public UILabel KillOrTaskCount;

	// Token: 0x040004A3 RID: 1187
	[Token(Token = "0x40004A3")]
	[FieldOffset(Offset = "0x48")]
	public GameObject OtherPlayerRoot;

	// Token: 0x040004A4 RID: 1188
	[Token(Token = "0x40004A4")]
	[FieldOffset(Offset = "0x50")]
	public UIButton AddFriendeBtn;

	// Token: 0x040004A5 RID: 1189
	[Token(Token = "0x40004A5")]
	[FieldOffset(Offset = "0x58")]
	public UISprite AddFriendSprite;

	// Token: 0x040004A6 RID: 1190
	[Token(Token = "0x40004A6")]
	[FieldOffset(Offset = "0x60")]
	public UIButton ThumbUPBtn;

	// Token: 0x040004A7 RID: 1191
	[Token(Token = "0x40004A7")]
	[FieldOffset(Offset = "0x68")]
	public UISprite ThumbUPSprite;

	// Token: 0x040004A8 RID: 1192
	[Token(Token = "0x40004A8")]
	[FieldOffset(Offset = "0x70")]
	public GameObject IsDeadRoot;

	// Token: 0x040004A9 RID: 1193
	[Token(Token = "0x40004A9")]
	[FieldOffset(Offset = "0x78")]
	public GameObject SelfColorBg;

	// Token: 0x040004AA RID: 1194
	[Token(Token = "0x40004AA")]
	[FieldOffset(Offset = "0x80")]
	public UISprite IconBg1;

	// Token: 0x040004AB RID: 1195
	[Token(Token = "0x40004AB")]
	[FieldOffset(Offset = "0x88")]
	public UISprite IconBg2;

	// Token: 0x040004AC RID: 1196
	[Token(Token = "0x40004AC")]
	[FieldOffset(Offset = "0x90")]
	public GameObject Mic;

	// Token: 0x040004AD RID: 1197
	[Token(Token = "0x40004AD")]
	[FieldOffset(Offset = "0x98")]
	private bool m_IsInited;

	// Token: 0x040004AE RID: 1198
	[Token(Token = "0x40004AE")]
	[FieldOffset(Offset = "0xA0")]
	private ulong m_UserID;

	// Token: 0x040004AF RID: 1199
	[Token(Token = "0x40004AF")]
	[FieldOffset(Offset = "0xA8")]
	private bool m_IsThumbUP;
}
