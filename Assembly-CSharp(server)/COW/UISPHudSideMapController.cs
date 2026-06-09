using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using Lean.Touch;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B99 RID: 7065
	[Token(Token = "0x2001B99")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA75C", Offset = "0x10FA75C")]
	internal class UISPHudSideMapController : UIMapBaseController
	{
		// Token: 0x06009864 RID: 39012 RVA: 0x00028248 File Offset: 0x00026448
		[Token(Token = "0x6009864")]
		[Address(RVA = "0x1EF2E9C", Offset = "0x1EF2E9C", VA = "0x7BBC6F2E9C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009865 RID: 39013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009865")]
		[Address(RVA = "0x1EF2EEC", Offset = "0x1EF2EEC", VA = "0x7BBC6F2EEC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009866 RID: 39014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009866")]
		[Address(RVA = "0x1EF3284", Offset = "0x1EF3284", VA = "0x7BBC6F3284", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009867 RID: 39015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009867")]
		[Address(RVA = "0x1EF3250", Offset = "0x1EF3250", VA = "0x7BBC6F3250")]
		private void InitUIElements()
		{
		}

		// Token: 0x06009868 RID: 39016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009868")]
		[Address(RVA = "0x1EF32B8", Offset = "0x1EF32B8", VA = "0x7BBC6F32B8", Slot = "28")]
		protected override void RegisterEvents()
		{
		}

		// Token: 0x06009869 RID: 39017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009869")]
		[Address(RVA = "0x1EF32C0", Offset = "0x1EF32C0", VA = "0x7BBC6F32C0", Slot = "29")]
		protected override void UnRegisterEvents()
		{
		}

		// Token: 0x0600986A RID: 39018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600986A")]
		[Address(RVA = "0x1EF32C8", Offset = "0x1EF32C8", VA = "0x7BBC6F32C8", Slot = "33")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600986B RID: 39019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600986B")]
		[Address(RVA = "0x1EF34A4", Offset = "0x1EF34A4", VA = "0x7BBC6F34A4", Slot = "34")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x0600986C RID: 39020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600986C")]
		[Address(RVA = "0x1EF36D0", Offset = "0x1EF36D0", VA = "0x7BBC6F36D0", Slot = "32")]
		protected override void OnPlayerHPChanged(params object[] data)
		{
		}

		// Token: 0x0600986D RID: 39021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600986D")]
		[Address(RVA = "0x1EF3708", Offset = "0x1EF3708", VA = "0x7BBC6F3708")]
		private void FingerSet(LeanFinger finger)
		{
		}

		// Token: 0x0600986E RID: 39022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600986E")]
		[Address(RVA = "0x1EF3918", Offset = "0x1EF3918", VA = "0x7BBC6F3918")]
		private void FingerDown(LeanFinger finger)
		{
		}

		// Token: 0x0600986F RID: 39023 RVA: 0x00028260 File Offset: 0x00026460
		[Token(Token = "0x600986F")]
		[Address(RVA = "0x1EF382C", Offset = "0x1EF382C", VA = "0x7BBC6F382C")]
		private bool IsMapTouched(Vector2 pos)
		{
			return default(bool);
		}

		// Token: 0x06009870 RID: 39024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009870")]
		[Address(RVA = "0x1EF3958", Offset = "0x1EF3958", VA = "0x7BBC6F3958")]
		private void Update()
		{
		}

		// Token: 0x06009871 RID: 39025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009871")]
		[Address(RVA = "0x1EF3A54", Offset = "0x1EF3A54", VA = "0x7BBC6F3A54", Slot = "30")]
		protected override void OnObservePlayer(params object[] data)
		{
		}

		// Token: 0x06009872 RID: 39026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009872")]
		[Address(RVA = "0x1EF3B60", Offset = "0x1EF3B60", VA = "0x7BBC6F3B60")]
		private void OnTweenFinished()
		{
		}

		// Token: 0x06009873 RID: 39027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009873")]
		[Address(RVA = "0x1EF3BB0", Offset = "0x1EF3BB0", VA = "0x7BBC6F3BB0")]
		public UISPHudSideMapController()
		{
		}

		// Token: 0x0400A031 RID: 41009
		[Token(Token = "0x400A031")]
		[FieldOffset(Offset = "0x60")]
		private UISPHudSideMapView m_View;

		// Token: 0x0400A032 RID: 41010
		[Token(Token = "0x400A032")]
		[FieldOffset(Offset = "0x68")]
		private Player m_Player;

		// Token: 0x0400A033 RID: 41011
		[Token(Token = "0x400A033")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 m_MinMapLocalScale;

		// Token: 0x0400A034 RID: 41012
		[Token(Token = "0x400A034")]
		private const float MAP_SIZE_HEIGHT = 1024f;

		// Token: 0x0400A035 RID: 41013
		[Token(Token = "0x400A035")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x112FA6C", Offset = "0x112FA6C")]
		public float WheelSensitivity;

		// Token: 0x0400A036 RID: 41014
		[Token(Token = "0x400A036")]
		[FieldOffset(Offset = "0x80")]
		private Vector2 m_LastTouchPos;

		// Token: 0x0400A037 RID: 41015
		[Token(Token = "0x400A037")]
		[FieldOffset(Offset = "0x88")]
		private bool m_IsShowing;
	}
}
