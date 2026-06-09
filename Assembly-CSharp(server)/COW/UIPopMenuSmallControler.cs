using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B08 RID: 6920
	[Token(Token = "0x2001B08")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9344", Offset = "0x10F9344")]
	public class UIPopMenuSmallControler : UIBaseController
	{
		// Token: 0x06009315 RID: 37653 RVA: 0x000271E0 File Offset: 0x000253E0
		[Token(Token = "0x6009315")]
		[Address(RVA = "0x20ED708", Offset = "0x20ED708", VA = "0x7BBC8ED708")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009316 RID: 37654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009316")]
		[Address(RVA = "0x20E8C54", Offset = "0x20E8C54", VA = "0x7BBC8E8C54", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009317 RID: 37655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009317")]
		[Address(RVA = "0x20ED3E8", Offset = "0x20ED3E8", VA = "0x7BBC8ED3E8", Slot = "28")]
		public virtual void InitPopMenu(Action injectDataListAction, ResourceID spriteRes, string Text, PopUpStyle style = PopUpStyle.Down, int cellWidth = 260, float maxShowCount = 4.5f, bool enable = true)
		{
		}

		// Token: 0x06009318 RID: 37656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009318")]
		[Address(RVA = "0x20ED758", Offset = "0x20ED758", VA = "0x7BBC8ED758", Slot = "29")]
		public virtual void SetPanelDepth(int depth)
		{
		}

		// Token: 0x06009319 RID: 37657 RVA: 0x000271F8 File Offset: 0x000253F8
		[Token(Token = "0x6009319")]
		[Address(RVA = "0x20ED80C", Offset = "0x20ED80C", VA = "0x7BBC8ED80C", Slot = "30")]
		public virtual int GetPanelDepth(int depth)
		{
			return 0;
		}

		// Token: 0x0600931A RID: 37658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600931A")]
		[Address(RVA = "0x20ED84C", Offset = "0x20ED84C", VA = "0x7BBC8ED84C", Slot = "31")]
		public virtual void SetEnable(bool enable)
		{
		}

		// Token: 0x0600931B RID: 37659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600931B")]
		[Address(RVA = "0x20ED9CC", Offset = "0x20ED9CC", VA = "0x7BBC8ED9CC", Slot = "32")]
		public virtual void UpdateSelectDataInfo(ResourceID spriteRes, string Text = "", string spritename = "")
		{
		}

		// Token: 0x0600931C RID: 37660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600931C")]
		[Address(RVA = "0x20EDF1C", Offset = "0x20EDF1C", VA = "0x7BBC8EDF1C", Slot = "33")]
		protected virtual void SetStyle(PopUpStyle style, int cellWidth = 260)
		{
		}

		// Token: 0x0600931D RID: 37661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600931D")]
		[Address(RVA = "0x20EE108", Offset = "0x20EE108", VA = "0x7BBC8EE108", Slot = "34")]
		protected virtual void AdjustScrollView()
		{
		}

		// Token: 0x0600931E RID: 37662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600931E")]
		[Address(RVA = "0x20EE49C", Offset = "0x20EE49C", VA = "0x7BBC8EE49C", Slot = "35")]
		public virtual void SetPopViewData(List<PopMenuData> dataList)
		{
		}

		// Token: 0x0600931F RID: 37663 RVA: 0x00027210 File Offset: 0x00025410
		[Token(Token = "0x600931F")]
		[Address(RVA = "0x20ED530", Offset = "0x20ED530", VA = "0x7BBC8ED530", Slot = "36")]
		protected virtual bool CallDataInject()
		{
			return default(bool);
		}

		// Token: 0x06009320 RID: 37664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009320")]
		[Address(RVA = "0x20EE4A4", Offset = "0x20EE4A4", VA = "0x7BBC8EE4A4", Slot = "37")]
		protected virtual void ShowPopUpItem()
		{
		}

		// Token: 0x06009321 RID: 37665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009321")]
		[Address(RVA = "0x20EF634", Offset = "0x20EF634", VA = "0x7BBC8EF634", Slot = "38")]
		public virtual void OnClickeMenuItem(PopMenuData data)
		{
		}

		// Token: 0x06009322 RID: 37666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009322")]
		[Address(RVA = "0x20EF678", Offset = "0x20EF678", VA = "0x7BBC8EF678", Slot = "39")]
		public virtual void SetCurrentSelectData(PopMenuData data)
		{
		}

		// Token: 0x06009323 RID: 37667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009323")]
		[Address(RVA = "0x20EF6FC", Offset = "0x20EF6FC", VA = "0x7BBC8EF6FC")]
		public PopMenuData GetCurrentSelectData()
		{
			return null;
		}

		// Token: 0x06009324 RID: 37668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009324")]
		[Address(RVA = "0x20EF704", Offset = "0x20EF704", VA = "0x7BBC8EF704", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009325 RID: 37669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009325")]
		[Address(RVA = "0x20EF73C", Offset = "0x20EF73C", VA = "0x7BBC8EF73C", Slot = "40")]
		protected virtual void OnPopMenuClose()
		{
		}

		// Token: 0x06009326 RID: 37670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009326")]
		[Address(RVA = "0x20EA9DC", Offset = "0x20EA9DC", VA = "0x7BBC8EA9DC")]
		public UIPopMenuSmallControler()
		{
		}

		// Token: 0x04009D3E RID: 40254
		[Token(Token = "0x4009D3E")]
		[FieldOffset(Offset = "0x58")]
		protected UIPopMenuSmallView m_View;

		// Token: 0x04009D3F RID: 40255
		[Token(Token = "0x4009D3F")]
		[FieldOffset(Offset = "0x60")]
		public Action DataInject;

		// Token: 0x04009D40 RID: 40256
		[Token(Token = "0x4009D40")]
		[FieldOffset(Offset = "0x68")]
		protected PopUpStyle m_Style;

		// Token: 0x04009D41 RID: 40257
		[Token(Token = "0x4009D41")]
		[FieldOffset(Offset = "0x70")]
		protected List<PopMenuData> m_DataList;

		// Token: 0x04009D42 RID: 40258
		[Token(Token = "0x4009D42")]
		[FieldOffset(Offset = "0x78")]
		protected List<UIPopMenuItemSmallController> m_UIPopMenuItemSmallControllerList;

		// Token: 0x04009D43 RID: 40259
		[Token(Token = "0x4009D43")]
		[FieldOffset(Offset = "0x80")]
		protected bool isShowing;

		// Token: 0x04009D44 RID: 40260
		[Token(Token = "0x4009D44")]
		[FieldOffset(Offset = "0x84")]
		protected int m_CellWidth;

		// Token: 0x04009D45 RID: 40261
		[Token(Token = "0x4009D45")]
		[FieldOffset(Offset = "0x88")]
		protected float m_MaxShowCount;

		// Token: 0x04009D46 RID: 40262
		[Token(Token = "0x4009D46")]
		[FieldOffset(Offset = "0x90")]
		protected PopMenuData m_CurrentSelectData;

		// Token: 0x04009D47 RID: 40263
		[Token(Token = "0x4009D47")]
		[FieldOffset(Offset = "0x98")]
		protected bool m_Enable;

		// Token: 0x04009D48 RID: 40264
		[Token(Token = "0x4009D48")]
		public const float SPLITLINE = 0.2f;

		// Token: 0x04009D49 RID: 40265
		[Token(Token = "0x4009D49")]
		public const int SMALLCELLHEIGHT = 38;

		// Token: 0x04009D4A RID: 40266
		[Token(Token = "0x4009D4A")]
		[FieldOffset(Offset = "0xA0")]
		protected UIClickMask m_UIClickMask;
	}
}
