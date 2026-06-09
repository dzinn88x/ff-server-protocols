using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001BF0 RID: 7152
	[Token(Token = "0x2001BF0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB314", Offset = "0x10FB314")]
	internal class UIWeaponZoomInController : UIPopupWindowController
	{
		// Token: 0x06009B57 RID: 39767 RVA: 0x00028CF8 File Offset: 0x00026EF8
		[Token(Token = "0x6009B57")]
		[Address(RVA = "0x1784720", Offset = "0x1784720", VA = "0x7BBBF84720")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009B58 RID: 39768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B58")]
		[Address(RVA = "0x1784770", Offset = "0x1784770", VA = "0x7BBBF84770", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009B59 RID: 39769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B59")]
		[Address(RVA = "0x1784CC0", Offset = "0x1784CC0", VA = "0x7BBBF84CC0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009B5A RID: 39770 RVA: 0x00028D10 File Offset: 0x00026F10
		[Token(Token = "0x6009B5A")]
		[Address(RVA = "0x1784E60", Offset = "0x1784E60", VA = "0x7BBBF84E60", Slot = "34")]
		protected override bool UseCustomizedAnimation()
		{
			return default(bool);
		}

		// Token: 0x06009B5B RID: 39771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B5B")]
		[Address(RVA = "0x1784BC0", Offset = "0x1784BC0", VA = "0x7BBBF84BC0")]
		private void SetItemCamState(bool enabled)
		{
		}

		// Token: 0x06009B5C RID: 39772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B5C")]
		[Address(RVA = "0x1784E68", Offset = "0x1784E68", VA = "0x7BBBF84E68")]
		public void ShowZoomItem(ResourceID resId, uint id, Vector3 position, Quaternion rotation, Vector3 scale, bool showArrow, bool isCreated, bool Rotate, bool backGroundEffect, [Optional] Action cb)
		{
		}

		// Token: 0x06009B5D RID: 39773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B5D")]
		[Address(RVA = "0x1785808", Offset = "0x1785808", VA = "0x7BBBF85808")]
		private void Rotate3DModel()
		{
		}

		// Token: 0x06009B5E RID: 39774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B5E")]
		[Address(RVA = "0x1785A2C", Offset = "0x1785A2C", VA = "0x7BBBF85A2C")]
		private void Update()
		{
		}

		// Token: 0x06009B5F RID: 39775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B5F")]
		[Address(RVA = "0x1785A68", Offset = "0x1785A68", VA = "0x7BBBF85A68")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x06009B60 RID: 39776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B60")]
		[Address(RVA = "0x1785BCC", Offset = "0x1785BCC", VA = "0x7BBBF85BCC")]
		private void OnZoomCancel(object[] data)
		{
		}

		// Token: 0x06009B61 RID: 39777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B61")]
		[Address(RVA = "0x1785BD0", Offset = "0x1785BD0", VA = "0x7BBBF85BD0")]
		public UIWeaponZoomInController()
		{
		}

		// Token: 0x0400A1B6 RID: 41398
		[Token(Token = "0x400A1B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UIWeaponZoomInView m_View;

		// Token: 0x0400A1B7 RID: 41399
		[Token(Token = "0x400A1B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private GameObject m_ItemCameraGo;

		// Token: 0x0400A1B8 RID: 41400
		[Token(Token = "0x400A1B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Camera m_ItemCamera;

		// Token: 0x0400A1B9 RID: 41401
		[Token(Token = "0x400A1B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GameObject m_ZoomItem;

		// Token: 0x0400A1BA RID: 41402
		[Token(Token = "0x400A1BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Action m_CallBack;

		// Token: 0x0400A1BB RID: 41403
		[Token(Token = "0x400A1BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool m_IsCreated;

		// Token: 0x0400A1BC RID: 41404
		[Token(Token = "0x400A1BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool m_CanRotated;

		// Token: 0x0400A1BD RID: 41405
		[Token(Token = "0x400A1BD")]
		private const float m_RotateRate = 0.5f;
	}
}
