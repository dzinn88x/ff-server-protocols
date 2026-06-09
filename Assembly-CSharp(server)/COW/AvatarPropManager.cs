using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace COW
{
	// Token: 0x0200108C RID: 4236
	[Token(Token = "0x200108C")]
	public class AvatarPropManager
	{
		// Token: 0x0600411D RID: 16669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600411D")]
		[Address(RVA = "0x1565548", Offset = "0x1565548", VA = "0x7BBBD65548")]
		public AvatarPropManager(Entity ownerEntity, bool isLocal)
		{
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600411E")]
		[Address(RVA = "0x1565620", Offset = "0x1565620", VA = "0x7BBBD65620")]
		public void ClearShowingWeapon()
		{
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x00013FC8 File Offset: 0x000121C8
		[Token(Token = "0x600411F")]
		[Address(RVA = "0x1565758", Offset = "0x1565758", VA = "0x7BBBD65758")]
		public bool IsDualWeild()
		{
			return default(bool);
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004120")]
		[Address(RVA = "0x15657D0", Offset = "0x15657D0", VA = "0x7BBBD657D0")]
		public void RecycleCurrentProp()
		{
		}

		// Token: 0x06004121 RID: 16673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004121")]
		[Address(RVA = "0x1565ABC", Offset = "0x1565ABC", VA = "0x7BBBD65ABC")]
		public void SetPropItemVisibiltiy(bool visible)
		{
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004122")]
		[Address(RVA = "0x1565C5C", Offset = "0x1565C5C", VA = "0x7BBBD65C5C")]
		public void SetPropCastShadow()
		{
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004123")]
		[Address(RVA = "0x1565EB0", Offset = "0x1565EB0", VA = "0x7BBBD65EB0")]
		private void ProcessCastShadow(GameObject go, ShadowCastingMode shadowCastingMode)
		{
		}

		// Token: 0x06004124 RID: 16676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004124")]
		[Address(RVA = "0x1566100", Offset = "0x1566100", VA = "0x7BBBD66100")]
		public void UpdatePropItem(PropertyData pData)
		{
		}

		// Token: 0x06004125 RID: 16677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004125")]
		[Address(RVA = "0x1566D80", Offset = "0x1566D80", VA = "0x7BBBD66D80")]
		public void ShowPropWeapon(bool show = true)
		{
		}

		// Token: 0x06004126 RID: 16678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004126")]
		[Address(RVA = "0x15656F0", Offset = "0x15656F0", VA = "0x7BBBD656F0")]
		public void UpdateWeaponItem(ResourceID weaponresid, ResourceID weaponpaticleid, ResourceID weaponfireeffectid, bool secondary = false)
		{
		}

		// Token: 0x06004127 RID: 16679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004127")]
		[Address(RVA = "0x156783C", Offset = "0x156783C", VA = "0x7BBBD6783C")]
		public void UpdateNoAnimWeaponItem(ResourceID weaponResId)
		{
		}

		// Token: 0x06004128 RID: 16680 RVA: 0x00013FE0 File Offset: 0x000121E0
		[Token(Token = "0x6004128")]
		[Address(RVA = "0x1567C24", Offset = "0x1567C24", VA = "0x7BBBD67C24")]
		public bool CheckHasWeapon()
		{
			return default(bool);
		}

		// Token: 0x06004129 RID: 16681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004129")]
		[Address(RVA = "0x1566E80", Offset = "0x1566E80", VA = "0x7BBBD66E80")]
		private void UpdateWeaponItem(ResourceID weaponresid, ResourceID weaponpaticleid, ResourceID weaponfireeffectid, ref GameObject propWeapon, ref ResourceID currentPropWeapon, ref Transform parent, ref GameObject propFireEffect, bool secondary)
		{
		}

		// Token: 0x0600412A RID: 16682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412A")]
		[Address(RVA = "0x1567C2C", Offset = "0x1567C2C", VA = "0x7BBBD67C2C")]
		public void UpdateSkyBoardItem(ResourceID skyboardid)
		{
		}

		// Token: 0x0600412B RID: 16683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412B")]
		[Address(RVA = "0x1566BA0", Offset = "0x1566BA0", VA = "0x7BBBD66BA0")]
		private void ResetObjectTransform(GameObject obj)
		{
		}

		// Token: 0x0600412C RID: 16684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412C")]
		[Address(RVA = "0x1567E8C", Offset = "0x1567E8C", VA = "0x7BBBD67E8C")]
		public void StartShowPose(bool immediately = false)
		{
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412D")]
		[Address(RVA = "0x1567FA0", Offset = "0x1567FA0", VA = "0x7BBBD67FA0")]
		public void PlayClothesChangeAnim()
		{
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412E")]
		[Address(RVA = "0x1568048", Offset = "0x1568048", VA = "0x7BBBD68048")]
		public void StopClothesChangeAnim()
		{
		}

		// Token: 0x0600412F RID: 16687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412F")]
		[Address(RVA = "0x1568118", Offset = "0x1568118", VA = "0x7BBBD68118")]
		public void StopShowPose(bool immediately = false)
		{
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004130")]
		[Address(RVA = "0x156822C", Offset = "0x156822C", VA = "0x7BBBD6822C")]
		public void SetOverrideAnim(AnimationClip clip, AnimationClip baseClip)
		{
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004131")]
		[Address(RVA = "0x15684D4", Offset = "0x15684D4", VA = "0x7BBBD684D4")]
		public void RebindAnimator()
		{
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004132")]
		[Address(RVA = "0x1568570", Offset = "0x1568570", VA = "0x7BBBD68570")]
		public void PlayLeftPropAnim(int index)
		{
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004133")]
		[Address(RVA = "0x1568624", Offset = "0x1568624", VA = "0x7BBBD68624")]
		public void PlayFistFireEffect(bool right)
		{
		}

		// Token: 0x04005083 RID: 20611
		[Token(Token = "0x4005083")]
		[FieldOffset(Offset = "0x10")]
		private GameObject m_PropGORight;

		// Token: 0x04005084 RID: 20612
		[Token(Token = "0x4005084")]
		[FieldOffset(Offset = "0x18")]
		private GameObject m_PropGOLeft;

		// Token: 0x04005085 RID: 20613
		[Token(Token = "0x4005085")]
		[FieldOffset(Offset = "0x20")]
		private GameObject m_PropGORoot;

		// Token: 0x04005086 RID: 20614
		[Token(Token = "0x4005086")]
		[FieldOffset(Offset = "0x28")]
		private GameObject m_PropGOHead;

		// Token: 0x04005087 RID: 20615
		[Token(Token = "0x4005087")]
		[FieldOffset(Offset = "0x30")]
		private GameObject m_PropSkyBoard;

		// Token: 0x04005088 RID: 20616
		[Token(Token = "0x4005088")]
		[FieldOffset(Offset = "0x38")]
		private GameObject m_PropWeapon;

		// Token: 0x04005089 RID: 20617
		[Token(Token = "0x4005089")]
		[FieldOffset(Offset = "0x40")]
		private ResourceID m_CurrentPropWeapon;

		// Token: 0x0400508A RID: 20618
		[Token(Token = "0x400508A")]
		[FieldOffset(Offset = "0x48")]
		private GameObject m_PropFireEffect;

		// Token: 0x0400508B RID: 20619
		[Token(Token = "0x400508B")]
		[FieldOffset(Offset = "0x50")]
		private GameObject m_PropSecondaryWeapon;

		// Token: 0x0400508C RID: 20620
		[Token(Token = "0x400508C")]
		[FieldOffset(Offset = "0x58")]
		private ResourceID m_CurrentSecondaryPropWeapon;

		// Token: 0x0400508D RID: 20621
		[Token(Token = "0x400508D")]
		[FieldOffset(Offset = "0x60")]
		private GameObject m_PropSecondaryFireEffect;

		// Token: 0x0400508E RID: 20622
		[Token(Token = "0x400508E")]
		[FieldOffset(Offset = "0x68")]
		private ResourceID m_CurrentPropIDRight;

		// Token: 0x0400508F RID: 20623
		[Token(Token = "0x400508F")]
		[FieldOffset(Offset = "0x6C")]
		private ResourceID m_CurrentPropIDLeft;

		// Token: 0x04005090 RID: 20624
		[Token(Token = "0x4005090")]
		[FieldOffset(Offset = "0x70")]
		private ResourceID m_CurrentPropIDRoot;

		// Token: 0x04005091 RID: 20625
		[Token(Token = "0x4005091")]
		[FieldOffset(Offset = "0x74")]
		private ResourceID m_CurrentPropIDHead;

		// Token: 0x04005092 RID: 20626
		[Token(Token = "0x4005092")]
		[FieldOffset(Offset = "0x78")]
		private Transform m_ParentRight;

		// Token: 0x04005093 RID: 20627
		[Token(Token = "0x4005093")]
		[FieldOffset(Offset = "0x80")]
		private Transform m_ParentLeft;

		// Token: 0x04005094 RID: 20628
		[Token(Token = "0x4005094")]
		[FieldOffset(Offset = "0x88")]
		private Transform m_ParentRoot;

		// Token: 0x04005095 RID: 20629
		[Token(Token = "0x4005095")]
		[FieldOffset(Offset = "0x90")]
		private Transform m_ParentHead;

		// Token: 0x04005096 RID: 20630
		[Token(Token = "0x4005096")]
		[FieldOffset(Offset = "0x98")]
		private Animator m_PropAnimator;

		// Token: 0x04005097 RID: 20631
		[Token(Token = "0x4005097")]
		[FieldOffset(Offset = "0xA0")]
		private PropAnimComponent m_LeftPropAnim;

		// Token: 0x04005098 RID: 20632
		[Token(Token = "0x4005098")]
		[FieldOffset(Offset = "0xA8")]
		private Entity m_OwnerEntity;

		// Token: 0x04005099 RID: 20633
		[Token(Token = "0x4005099")]
		[FieldOffset(Offset = "0xB0")]
		private bool hasweapon;

		// Token: 0x0400509A RID: 20634
		[Token(Token = "0x400509A")]
		[FieldOffset(Offset = "0xB1")]
		private bool isLocalPlayer;
	}
}
