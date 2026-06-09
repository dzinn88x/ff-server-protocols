using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001BE4 RID: 7140
	[Token(Token = "0x2001BE4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB16C", Offset = "0x10FB16C")]
	internal class UIWeaponSkinUpgraderFeatureController : UIPopupWindowController
	{
		// Token: 0x06009AE5 RID: 39653 RVA: 0x00028BA8 File Offset: 0x00026DA8
		[Token(Token = "0x6009AE5")]
		[Address(RVA = "0x2228A48", Offset = "0x2228A48", VA = "0x7BBCA28A48")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009AE6 RID: 39654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AE6")]
		[Address(RVA = "0x2228A98", Offset = "0x2228A98", VA = "0x7BBCA28A98", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009AE7 RID: 39655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AE7")]
		[Address(RVA = "0x2229108", Offset = "0x2229108", VA = "0x7BBCA29108", Slot = "39")]
		public override void OnPopupWindowListChange()
		{
		}

		// Token: 0x06009AE8 RID: 39656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AE8")]
		[Address(RVA = "0x22291D8", Offset = "0x22291D8", VA = "0x7BBCA291D8")]
		public void ShowFeatureView(WeaponSkinData data, WeaponSkinFeature feature)
		{
		}

		// Token: 0x06009AE9 RID: 39657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AE9")]
		[Address(RVA = "0x222A140", Offset = "0x222A140", VA = "0x7BBCA2A140")]
		private void CreateFeature()
		{
		}

		// Token: 0x06009AEA RID: 39658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AEA")]
		[Address(RVA = "0x222A824", Offset = "0x222A824", VA = "0x7BBCA2A824")]
		private void UpdateSkinMeshRender(bool flag)
		{
		}

		// Token: 0x06009AEB RID: 39659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AEB")]
		[Address(RVA = "0x222AA14", Offset = "0x222AA14", VA = "0x7BBCA2AA14")]
		private void OnShowFeature(params object[] data)
		{
		}

		// Token: 0x06009AEC RID: 39660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AEC")]
		[Address(RVA = "0x2229434", Offset = "0x2229434", VA = "0x7BBCA29434")]
		private void EnableUI(bool v)
		{
		}

		// Token: 0x06009AED RID: 39661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AED")]
		[Address(RVA = "0x222B8FC", Offset = "0x222B8FC", VA = "0x7BBCA2B8FC")]
		public void SetFeatureCameraDepth(float depth)
		{
		}

		// Token: 0x06009AEE RID: 39662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AEE")]
		[Address(RVA = "0x222BA0C", Offset = "0x222BA0C", VA = "0x7BBCA2BA0C")]
		public void Set3DModelVisiable(bool b)
		{
		}

		// Token: 0x06009AEF RID: 39663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AEF")]
		[Address(RVA = "0x2229E98", Offset = "0x2229E98", VA = "0x7BBCA29E98")]
		private void CreateCamera()
		{
		}

		// Token: 0x06009AF0 RID: 39664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AF0")]
		[Address(RVA = "0x222A2F8", Offset = "0x222A2F8", VA = "0x7BBCA2A2F8")]
		private void CreateFetureItem()
		{
		}

		// Token: 0x06009AF1 RID: 39665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AF1")]
		[Address(RVA = "0x2228D8C", Offset = "0x2228D8C", VA = "0x7BBCA28D8C")]
		public void DisplayWeaponPropertyScore(bool show)
		{
		}

		// Token: 0x06009AF2 RID: 39666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AF2")]
		[Address(RVA = "0x222B38C", Offset = "0x222B38C", VA = "0x7BBCA2B38C")]
		public void RefreshWeaponPropertyScore(bool isShow)
		{
		}

		// Token: 0x06009AF3 RID: 39667 RVA: 0x00028BC0 File Offset: 0x00026DC0
		[Token(Token = "0x6009AF3")]
		[Address(RVA = "0x222BAD4", Offset = "0x222BAD4", VA = "0x7BBCA2BAD4")]
		private bool CheckItemABReady(uint itemID)
		{
			return default(bool);
		}

		// Token: 0x06009AF4 RID: 39668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AF4")]
		[Address(RVA = "0x222BC68", Offset = "0x222BC68", VA = "0x7BBCA2BC68")]
		private void CreateRigidbody(ResourceID resID)
		{
		}

		// Token: 0x06009AF5 RID: 39669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AF5")]
		[Address(RVA = "0x222AD80", Offset = "0x222AD80", VA = "0x7BBCA2AD80")]
		private void Adjust3DModel(Dictionary<int, UIWeaponSkinUpgraderFeatureController.ModelTransformerAttri> transAttriDict)
		{
		}

		// Token: 0x06009AF6 RID: 39670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AF6")]
		[Address(RVA = "0x2229E5C", Offset = "0x2229E5C", VA = "0x7BBCA29E5C")]
		private void SetDoNeedRotate()
		{
		}

		// Token: 0x06009AF7 RID: 39671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009AF7")]
		[Address(RVA = "0x222BE2C", Offset = "0x222BE2C", VA = "0x7BBCA2BE2C")]
		private Transform GetSubTransfrom()
		{
			return null;
		}

		// Token: 0x06009AF8 RID: 39672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AF8")]
		[Address(RVA = "0x222BEEC", Offset = "0x222BEEC", VA = "0x7BBCA2BEEC")]
		private void Rotate3DModel()
		{
		}

		// Token: 0x06009AF9 RID: 39673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AF9")]
		[Address(RVA = "0x222C244", Offset = "0x222C244", VA = "0x7BBCA2C244")]
		private void Update()
		{
		}

		// Token: 0x06009AFA RID: 39674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AFA")]
		[Address(RVA = "0x222C280", Offset = "0x222C280", VA = "0x7BBCA2C280")]
		private void OnOKBtnClick()
		{
		}

		// Token: 0x06009AFB RID: 39675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AFB")]
		[Address(RVA = "0x222C288", Offset = "0x222C288", VA = "0x7BBCA2C288")]
		private void OnShareBtnClik()
		{
		}

		// Token: 0x06009AFC RID: 39676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AFC")]
		[Address(RVA = "0x222C6D0", Offset = "0x222C6D0", VA = "0x7BBCA2C6D0", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x06009AFD RID: 39677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AFD")]
		[Address(RVA = "0x222C6FC", Offset = "0x222C6FC", VA = "0x7BBCA2C6FC", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x06009AFE RID: 39678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AFE")]
		[Address(RVA = "0x222C728", Offset = "0x222C728", VA = "0x7BBCA2C728", Slot = "25")]
		public override void BeforeSharePreview()
		{
		}

		// Token: 0x06009AFF RID: 39679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AFF")]
		[Address(RVA = "0x222C754", Offset = "0x222C754", VA = "0x7BBCA2C754", Slot = "26")]
		public override void AfterSharePreview()
		{
		}

		// Token: 0x06009B00 RID: 39680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B00")]
		[Address(RVA = "0x2229494", Offset = "0x2229494", VA = "0x7BBCA29494")]
		private void SetShareUIVisiable(bool isScreenShot)
		{
		}

		// Token: 0x06009B01 RID: 39681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B01")]
		[Address(RVA = "0x222BC1C", Offset = "0x222BC1C", VA = "0x7BBCA2BC1C")]
		private void SetTouchEnable(bool b)
		{
		}

		// Token: 0x06009B02 RID: 39682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B02")]
		[Address(RVA = "0x2229D98", Offset = "0x2229D98", VA = "0x7BBCA29D98")]
		private void AdjustBGScale()
		{
		}

		// Token: 0x06009B03 RID: 39683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B03")]
		[Address(RVA = "0x22295B4", Offset = "0x22295B4", VA = "0x7BBCA295B4")]
		private void UpdateViewInfo()
		{
		}

		// Token: 0x06009B04 RID: 39684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B04")]
		[Address(RVA = "0x222C780", Offset = "0x222C780", VA = "0x7BBCA2C780")]
		public void ShowIPTag()
		{
		}

		// Token: 0x06009B05 RID: 39685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B05")]
		[Address(RVA = "0x222C3BC", Offset = "0x222C3BC", VA = "0x7BBCA2C3BC")]
		private void ChangeLayer(Transform trans, string targetLayer)
		{
		}

		// Token: 0x06009B06 RID: 39686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B06")]
		[Address(RVA = "0x222A13C", Offset = "0x222A13C", VA = "0x7BBCA2A13C")]
		private void PlayPopWndSound()
		{
		}

		// Token: 0x06009B07 RID: 39687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B07")]
		[Address(RVA = "0x222CB38", Offset = "0x222CB38", VA = "0x7BBCA2CB38")]
		private void Destroy3DModel()
		{
		}

		// Token: 0x06009B08 RID: 39688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B08")]
		[Address(RVA = "0x222CC50", Offset = "0x222CC50", VA = "0x7BBCA2CC50", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06009B09 RID: 39689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B09")]
		[Address(RVA = "0x222CCD8", Offset = "0x222CCD8", VA = "0x7BBCA2CCD8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009B0A RID: 39690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B0A")]
		[Address(RVA = "0x222CECC", Offset = "0x222CECC", VA = "0x7BBCA2CECC")]
		public UIWeaponSkinUpgraderFeatureController()
		{
		}

		// Token: 0x0400A17E RID: 41342
		[Token(Token = "0x400A17E")]
		[FieldOffset(Offset = "0x98")]
		private UIWeaponSkinUpgraderFeatureView m_View;

		// Token: 0x0400A17F RID: 41343
		[Token(Token = "0x400A17F")]
		[FieldOffset(Offset = "0xA0")]
		private GameObject m_FeatureModel;

		// Token: 0x0400A180 RID: 41344
		[Token(Token = "0x400A180")]
		[FieldOffset(Offset = "0xA8")]
		private UIWeaponKillNotificationItemController m_AnnouncementCtrl;

		// Token: 0x0400A181 RID: 41345
		[Token(Token = "0x400A181")]
		[FieldOffset(Offset = "0xB0")]
		private Transform m_FeatureSubTrans;

		// Token: 0x0400A182 RID: 41346
		[Token(Token = "0x400A182")]
		[FieldOffset(Offset = "0xB8")]
		private UIMaleAvatar m_FeatureAvatar;

		// Token: 0x0400A183 RID: 41347
		[Token(Token = "0x400A183")]
		[FieldOffset(Offset = "0xC0")]
		private GameObject m_FeatureCamera;

		// Token: 0x0400A184 RID: 41348
		[Token(Token = "0x400A184")]
		[FieldOffset(Offset = "0xC8")]
		private CSSharedItemData m_Data;

		// Token: 0x0400A185 RID: 41349
		[Token(Token = "0x400A185")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_IsWeaponSkinFeature;

		// Token: 0x0400A186 RID: 41350
		[Token(Token = "0x400A186")]
		[FieldOffset(Offset = "0xD8")]
		private WeaponSkinData m_WeaponSkinData;

		// Token: 0x0400A187 RID: 41351
		[Token(Token = "0x400A187")]
		[FieldOffset(Offset = "0xE0")]
		private WeaponSkinFeature m_WeaponSkinFeature;

		// Token: 0x0400A188 RID: 41352
		[Token(Token = "0x400A188")]
		private const float m_RotateRate = 0.5f;

		// Token: 0x0400A189 RID: 41353
		[Token(Token = "0x400A189")]
		[FieldOffset(Offset = "0xE4")]
		private bool m_NeedRotate;

		// Token: 0x0400A18A RID: 41354
		[Token(Token = "0x400A18A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<int, UIWeaponSkinUpgraderFeatureController.ModelTransformerAttri> m_TransAttriDict;

		// Token: 0x0400A18B RID: 41355
		[Token(Token = "0x400A18B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<int, UIWeaponSkinUpgraderFeatureController.ModelTransformerAttri> m_TransAttriDictLucyBag;

		// Token: 0x0400A18C RID: 41356
		[Token(Token = "0x400A18C")]
		[FieldOffset(Offset = "0xE8")]
		public Action m_CloseAction;

		// Token: 0x02001BE5 RID: 7141
		[Token(Token = "0x2001BE5")]
		private class ModelTransformerAttri
		{
			// Token: 0x06009B0C RID: 39692 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009B0C")]
			[Address(RVA = "0x222DBA4", Offset = "0x222DBA4", VA = "0x7BBCA2DBA4")]
			public ModelTransformerAttri(Vector3 pos, Vector3 rot, Vector3 scale)
			{
			}

			// Token: 0x0400A18D RID: 41357
			[Token(Token = "0x400A18D")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 m_Pos;

			// Token: 0x0400A18E RID: 41358
			[Token(Token = "0x400A18E")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 m_Rot;

			// Token: 0x0400A18F RID: 41359
			[Token(Token = "0x400A18F")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 m_Scale;
		}
	}
}
