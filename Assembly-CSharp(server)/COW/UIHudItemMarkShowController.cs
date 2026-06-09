using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018F3 RID: 6387
	[Token(Token = "0x20018F3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5414", Offset = "0x10F5414")]
	internal class UIHudItemMarkShowController : UIHudNameBaseController
	{
		// Token: 0x06008015 RID: 32789 RVA: 0x00022ED8 File Offset: 0x000210D8
		[Token(Token = "0x6008015")]
		[Address(RVA = "0x1C49CDC", Offset = "0x1C49CDC", VA = "0x7BBC449CDC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008016 RID: 32790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008016")]
		[Address(RVA = "0x1C49D2C", Offset = "0x1C49D2C", VA = "0x7BBC449D2C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008017 RID: 32791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008017")]
		[Address(RVA = "0x1C49E1C", Offset = "0x1C49E1C", VA = "0x7BBC449E1C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008018 RID: 32792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008018")]
		[Address(RVA = "0x1C49E24", Offset = "0x1C49E24", VA = "0x7BBC449E24", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008019 RID: 32793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008019")]
		[Address(RVA = "0x1C49E2C", Offset = "0x1C49E2C", VA = "0x7BBC449E2C")]
		public void BindPlayerAndWorldPosition(Player player, Vector3 targetPosition, int fixCount)
		{
		}

		// Token: 0x0600801A RID: 32794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600801A")]
		[Address(RVA = "0x1C49E38", Offset = "0x1C49E38", VA = "0x7BBC449E38")]
		public void SetUIShowData(uint markID, uint containerID, Color teamateColor, bool needRecycle)
		{
		}

		// Token: 0x0600801B RID: 32795 RVA: 0x00022EF0 File Offset: 0x000210F0
		[Token(Token = "0x600801B")]
		[Address(RVA = "0x1C4A1A0", Offset = "0x1C4A1A0", VA = "0x7BBC44A1A0", Slot = "30")]
		protected override bool NeedKeepInScreen()
		{
			return default(bool);
		}

		// Token: 0x0600801C RID: 32796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600801C")]
		[Address(RVA = "0x1C4A1A8", Offset = "0x1C4A1A8", VA = "0x7BBC44A1A8")]
		private void ResetUI()
		{
		}

		// Token: 0x0600801D RID: 32797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600801D")]
		[Address(RVA = "0x1C4A230", Offset = "0x1C4A230", VA = "0x7BBC44A230")]
		public void RemoveMarkUI(uint itemID, uint containerID)
		{
		}

		// Token: 0x0600801E RID: 32798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600801E")]
		[Address(RVA = "0x1C4A250", Offset = "0x1C4A250", VA = "0x7BBC44A250")]
		public void RemoveMarkUI()
		{
		}

		// Token: 0x0600801F RID: 32799 RVA: 0x00022F08 File Offset: 0x00021108
		[Token(Token = "0x600801F")]
		[Address(RVA = "0x1C4A254", Offset = "0x1C4A254", VA = "0x7BBC44A254", Slot = "31")]
		protected override bool NeedUpdatePosition()
		{
			return default(bool);
		}

		// Token: 0x06008020 RID: 32800 RVA: 0x00022F20 File Offset: 0x00021120
		[Token(Token = "0x6008020")]
		[Address(RVA = "0x1C4A2F0", Offset = "0x1C4A2F0", VA = "0x7BBC44A2F0", Slot = "28")]
		protected override Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06008021 RID: 32801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008021")]
		[Address(RVA = "0x1C4A42C", Offset = "0x1C4A42C", VA = "0x7BBC44A42C")]
		private void RefreshDistanceToLocalPlayer()
		{
		}

		// Token: 0x06008022 RID: 32802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008022")]
		[Address(RVA = "0x1C4A5DC", Offset = "0x1C4A5DC", VA = "0x7BBC44A5DC")]
		private void HideAllInfo()
		{
		}

		// Token: 0x06008023 RID: 32803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008023")]
		[Address(RVA = "0x1C4A620", Offset = "0x1C4A620", VA = "0x7BBC44A620")]
		private void ShowAllInfo()
		{
		}

		// Token: 0x06008024 RID: 32804 RVA: 0x00022F38 File Offset: 0x00021138
		[Token(Token = "0x6008024")]
		[Address(RVA = "0x1C4A664", Offset = "0x1C4A664", VA = "0x7BBC44A664", Slot = "37")]
		protected override Vector2 GetWidgetBound()
		{
			return default(Vector2);
		}

		// Token: 0x06008025 RID: 32805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008025")]
		[Address(RVA = "0x1C4A6A0", Offset = "0x1C4A6A0", VA = "0x7BBC44A6A0", Slot = "35")]
		protected override void LateUpdate()
		{
		}

		// Token: 0x06008026 RID: 32806 RVA: 0x00022F50 File Offset: 0x00021150
		[Token(Token = "0x6008026")]
		[Address(RVA = "0x1C4A6C8", Offset = "0x1C4A6C8", VA = "0x7BBC44A6C8", Slot = "32")]
		protected override bool NeedShowDistance()
		{
			return default(bool);
		}

		// Token: 0x06008027 RID: 32807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008027")]
		[Address(RVA = "0x1C4A6D0", Offset = "0x1C4A6D0", VA = "0x7BBC44A6D0")]
		public UIHudItemMarkShowController()
		{
		}

		// Token: 0x04009280 RID: 37504
		[Token(Token = "0x4009280")]
		private const float UI_SHOW_OFFSET = 1f;

		// Token: 0x04009281 RID: 37505
		[Token(Token = "0x4009281")]
		[FieldOffset(Offset = "0xA8")]
		private UIHudItemMarkShowView m_View;

		// Token: 0x04009282 RID: 37506
		[Token(Token = "0x4009282")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 m_bindWorldPosition;

		// Token: 0x04009283 RID: 37507
		[Token(Token = "0x4009283")]
		[FieldOffset(Offset = "0xBC")]
		private uint m_ItemID;

		// Token: 0x04009284 RID: 37508
		[Token(Token = "0x4009284")]
		[FieldOffset(Offset = "0xC0")]
		private uint m_ContainerID;
	}
}
