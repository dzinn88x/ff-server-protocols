using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B11 RID: 6929
	[Token(Token = "0x2001B11")]
	public class UIPortraitCloseupController : UINavigationController
	{
		// Token: 0x06009346 RID: 37702 RVA: 0x00027258 File Offset: 0x00025458
		[Token(Token = "0x6009346")]
		[Address(RVA = "0x216EB84", Offset = "0x216EB84", VA = "0x7BBC96EB84")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009347 RID: 37703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009347")]
		[Address(RVA = "0x216EBD4", Offset = "0x216EBD4", VA = "0x7BBC96EBD4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009348 RID: 37704 RVA: 0x00027270 File Offset: 0x00025470
		[Token(Token = "0x6009348")]
		[Address(RVA = "0x216EDC4", Offset = "0x216EDC4", VA = "0x7BBC96EDC4", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06009349 RID: 37705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009349")]
		[Address(RVA = "0x216EDCC", Offset = "0x216EDCC", VA = "0x7BBC96EDCC", Slot = "36")]
		public override List<string> GetNeedShowUI3dObjectNames()
		{
			return null;
		}

		// Token: 0x0600934A RID: 37706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600934A")]
		[Address(RVA = "0x216EE5C", Offset = "0x216EE5C", VA = "0x7BBC96EE5C", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x0600934B RID: 37707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600934B")]
		[Address(RVA = "0x216F328", Offset = "0x216F328", VA = "0x7BBC96F328", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x0600934C RID: 37708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600934C")]
		[Address(RVA = "0x216F3D4", Offset = "0x216F3D4", VA = "0x7BBC96F3D4")]
		private void OnExitBtnClick()
		{
		}

		// Token: 0x0600934D RID: 37709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600934D")]
		[Address(RVA = "0x216F470", Offset = "0x216F470", VA = "0x7BBC96F470")]
		private void OnTakePhotoBtnClick()
		{
		}

		// Token: 0x0600934E RID: 37710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600934E")]
		[Address(RVA = "0x216F554", Offset = "0x216F554", VA = "0x7BBC96F554")]
		private void OnZoomInOutBtnClick()
		{
		}

		// Token: 0x0600934F RID: 37711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600934F")]
		[Address(RVA = "0x216F7EC", Offset = "0x216F7EC", VA = "0x7BBC96F7EC")]
		private void SetMagnifierState(bool b)
		{
		}

		// Token: 0x06009350 RID: 37712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009350")]
		[Address(RVA = "0x216F880", Offset = "0x216F880", VA = "0x7BBC96F880", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x06009351 RID: 37713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009351")]
		[Address(RVA = "0x216F930", Offset = "0x216F930", VA = "0x7BBC96F930", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x06009352 RID: 37714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009352")]
		[Address(RVA = "0x216F13C", Offset = "0x216F13C", VA = "0x7BBC96F13C")]
		private GameObject GetBgObj()
		{
			return null;
		}

		// Token: 0x06009353 RID: 37715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009353")]
		[Address(RVA = "0x216F248", Offset = "0x216F248", VA = "0x7BBC96F248")]
		private GameObject GetCamObj()
		{
			return null;
		}

		// Token: 0x06009354 RID: 37716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009354")]
		[Address(RVA = "0x216F9E0", Offset = "0x216F9E0", VA = "0x7BBC96F9E0")]
		public UIPortraitCloseupController()
		{
		}

		// Token: 0x06009355 RID: 37717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009355")]
		[Address(RVA = "0x216FADC", Offset = "0x216FADC", VA = "0x7BBC96FADC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144B20", Offset = "0x1144B20")]
		private void <OnZoomInOutBtnClick>b__21_0()
		{
		}

		// Token: 0x04009D81 RID: 40321
		[Token(Token = "0x4009D81")]
		[FieldOffset(Offset = "0xB0")]
		private UIPortraitCloseupView m_View;

		// Token: 0x04009D82 RID: 40322
		[Token(Token = "0x4009D82")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_IsZoomIn;

		// Token: 0x04009D83 RID: 40323
		[Token(Token = "0x4009D83")]
		[FieldOffset(Offset = "0xB9")]
		private bool m_IsMoving;

		// Token: 0x04009D84 RID: 40324
		[Token(Token = "0x4009D84")]
		[FieldOffset(Offset = "0xC0")]
		private AvatarCameraMoveComp m_AvatarMoveComp;

		// Token: 0x04009D85 RID: 40325
		[Token(Token = "0x4009D85")]
		[FieldOffset(Offset = "0xC8")]
		private Vector3 m_ProfilePageCamPos;

		// Token: 0x04009D86 RID: 40326
		[Token(Token = "0x4009D86")]
		[FieldOffset(Offset = "0xD4")]
		private float m_ProfilePageBGSize;

		// Token: 0x04009D87 RID: 40327
		[Token(Token = "0x4009D87")]
		[FieldOffset(Offset = "0xD8")]
		private float m_ZoomInBgSize;

		// Token: 0x04009D88 RID: 40328
		[Token(Token = "0x4009D88")]
		[FieldOffset(Offset = "0xDC")]
		private float m_ZoomOutBgSize;

		// Token: 0x04009D89 RID: 40329
		[Token(Token = "0x4009D89")]
		[FieldOffset(Offset = "0xE0")]
		private Vector3 m_ZoomInCamPos;

		// Token: 0x04009D8A RID: 40330
		[Token(Token = "0x4009D8A")]
		[FieldOffset(Offset = "0xEC")]
		private Vector3 m_ZoomOutCamPos;

		// Token: 0x04009D8B RID: 40331
		[Token(Token = "0x4009D8B")]
		private const string ZOOMINICON = "UI_Icon_zoomin";

		// Token: 0x04009D8C RID: 40332
		[Token(Token = "0x4009D8C")]
		private const string ZOOMOUTICON = "UI_Icon_zoomout";

		// Token: 0x04009D8D RID: 40333
		[Token(Token = "0x4009D8D")]
		private const float MOVE_DURATION = 0.8f;
	}
}
