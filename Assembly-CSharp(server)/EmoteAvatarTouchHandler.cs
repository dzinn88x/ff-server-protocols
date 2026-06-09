using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000125 RID: 293
[Token(Token = "0x2000125")]
public class EmoteAvatarTouchHandler : MonoBehaviour
{
	// Token: 0x06000574 RID: 1396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000574")]
	[Address(RVA = "0x23F4B54", Offset = "0x23F4B54", VA = "0x7BBCBF4B54")]
	private void Awake()
	{
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000575")]
	[Address(RVA = "0x23F4BD0", Offset = "0x23F4BD0", VA = "0x7BBCBF4BD0")]
	private void Update()
	{
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000576")]
	[Address(RVA = "0x23F4BD4", Offset = "0x23F4BD4", VA = "0x7BBCBF4BD4")]
	private void CheckTouchAvatar()
	{
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000577")]
	[Address(RVA = "0x23F52CC", Offset = "0x23F52CC", VA = "0x7BBCBF52CC", Slot = "4")]
	protected virtual void OnTouchAvatar()
	{
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x00002FD0 File Offset: 0x000011D0
	[Token(Token = "0x6000578")]
	[Address(RVA = "0x23F5174", Offset = "0x23F5174", VA = "0x7BBCBF5174")]
	private bool IsCamAvalible(Camera cam)
	{
		return default(bool);
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000579")]
	[Address(RVA = "0x23F5458", Offset = "0x23F5458", VA = "0x7BBCBF5458")]
	public EmoteAvatarTouchHandler()
	{
	}

	// Token: 0x040004B0 RID: 1200
	[Token(Token = "0x40004B0")]
	[FieldOffset(Offset = "0x18")]
	private Camera cam;

	// Token: 0x040004B1 RID: 1201
	[Token(Token = "0x40004B1")]
	[FieldOffset(Offset = "0x20")]
	private UIPopupWindowController popWinCtrl;

	// Token: 0x040004B2 RID: 1202
	[Token(Token = "0x40004B2")]
	[FieldOffset(Offset = "0x28")]
	private Type naviType;

	// Token: 0x040004B3 RID: 1203
	[Token(Token = "0x40004B3")]
	[FieldOffset(Offset = "0x30")]
	private float OffsetX;

	// Token: 0x040004B4 RID: 1204
	[Token(Token = "0x40004B4")]
	[FieldOffset(Offset = "0x34")]
	private float OffsetY;

	// Token: 0x040004B5 RID: 1205
	[Token(Token = "0x40004B5")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 pressPos;

	// Token: 0x040004B6 RID: 1206
	[Token(Token = "0x40004B6")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 releasePos;
}
