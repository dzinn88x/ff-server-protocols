using System;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001983 RID: 6531
	[Token(Token = "0x2001983")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F66B4", Offset = "0x10F66B4")]
	public class UIHudTriggerEventMarkController : UIHudNameBaseController
	{
		// Token: 0x0600851C RID: 34076 RVA: 0x00024180 File Offset: 0x00022380
		[Token(Token = "0x600851C")]
		[Address(RVA = "0x15EB1B8", Offset = "0x15EB1B8", VA = "0x7BBBDEB1B8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600851D RID: 34077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600851D")]
		[Address(RVA = "0x15EB208", Offset = "0x15EB208", VA = "0x7BBBDEB208", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600851E RID: 34078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600851E")]
		[Address(RVA = "0x15EB2E0", Offset = "0x15EB2E0", VA = "0x7BBBDEB2E0")]
		public void BindWorldPosition(Vector3 targetPosition)
		{
		}

		// Token: 0x0600851F RID: 34079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600851F")]
		[Address(RVA = "0x15EB2EC", Offset = "0x15EB2EC", VA = "0x7BBBDEB2EC")]
		public void HideUIShowData()
		{
		}

		// Token: 0x06008520 RID: 34080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008520")]
		[Address(RVA = "0x15EB550", Offset = "0x15EB550", VA = "0x7BBBDEB550")]
		public void SetUIShowData(InGameTriggerMaskData data, bool needRecycle)
		{
		}

		// Token: 0x06008521 RID: 34081 RVA: 0x00024198 File Offset: 0x00022398
		[Token(Token = "0x6008521")]
		[Address(RVA = "0x15EB8D0", Offset = "0x15EB8D0", VA = "0x7BBBDEB8D0")]
		private Color GetColorByMarkType(a}ZGLej markType)
		{
			return default(Color);
		}

		// Token: 0x06008522 RID: 34082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008522")]
		[Address(RVA = "0x15EB2F0", Offset = "0x15EB2F0", VA = "0x7BBBDEB2F0")]
		private void ResetUI()
		{
		}

		// Token: 0x06008523 RID: 34083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008523")]
		[Address(RVA = "0x15EB948", Offset = "0x15EB948", VA = "0x7BBBDEB948")]
		public void SetShowDistance(bool enable)
		{
		}

		// Token: 0x06008524 RID: 34084 RVA: 0x000241B0 File Offset: 0x000223B0
		[Token(Token = "0x6008524")]
		[Address(RVA = "0x15EB9C0", Offset = "0x15EB9C0", VA = "0x7BBBDEB9C0", Slot = "31")]
		protected override bool NeedUpdatePosition()
		{
			return default(bool);
		}

		// Token: 0x06008525 RID: 34085 RVA: 0x000241C8 File Offset: 0x000223C8
		[Token(Token = "0x6008525")]
		[Address(RVA = "0x15EBA78", Offset = "0x15EBA78", VA = "0x7BBBDEBA78", Slot = "28")]
		protected override Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06008526 RID: 34086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008526")]
		[Address(RVA = "0x15EBBD0", Offset = "0x15EBBD0", VA = "0x7BBBDEBBD0")]
		private void SetDistance(int distance)
		{
		}

		// Token: 0x06008527 RID: 34087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008527")]
		[Address(RVA = "0x15EBD20", Offset = "0x15EBD20", VA = "0x7BBBDEBD20")]
		private void RefreshDistanceToLocalPlayer()
		{
		}

		// Token: 0x06008528 RID: 34088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008528")]
		[Address(RVA = "0x15EBEC0", Offset = "0x15EBEC0", VA = "0x7BBBDEBEC0", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06008529 RID: 34089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008529")]
		[Address(RVA = "0x15EBF64", Offset = "0x15EBF64", VA = "0x7BBBDEBF64", Slot = "35")]
		protected override void LateUpdate()
		{
		}

		// Token: 0x0600852A RID: 34090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600852A")]
		[Address(RVA = "0x15EBF8C", Offset = "0x15EBF8C", VA = "0x7BBBDEBF8C")]
		public UIHudTriggerEventMarkController()
		{
		}

		// Token: 0x040094E5 RID: 38117
		[Token(Token = "0x40094E5")]
		[FieldOffset(Offset = "0xA8")]
		private UIEventTriggerView m_View;

		// Token: 0x040094E6 RID: 38118
		[Token(Token = "0x40094E6")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 m_bindWorldPosition;

		// Token: 0x040094E7 RID: 38119
		[Token(Token = "0x40094E7")]
		[FieldOffset(Offset = "0xC0")]
		private StringBuilder m_Distance;

		// Token: 0x040094E8 RID: 38120
		[Token(Token = "0x40094E8")]
		[FieldOffset(Offset = "0xC8")]
		private int m_PrevDistance;

		// Token: 0x040094E9 RID: 38121
		[Token(Token = "0x40094E9")]
		[FieldOffset(Offset = "0xCC")]
		private bool m_NeedShowDistance;

		// Token: 0x040094EA RID: 38122
		[Token(Token = "0x40094EA")]
		[FieldOffset(Offset = "0xD0")]
		private uint m_CurrentDelegate;

		// Token: 0x040094EB RID: 38123
		[Token(Token = "0x40094EB")]
		[FieldOffset(Offset = "0xD8")]
		private InGameTriggerMaskData m_showData;

		// Token: 0x040094EC RID: 38124
		[Token(Token = "0x40094EC")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_NeedRecycle;
	}
}
