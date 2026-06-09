using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C41 RID: 7233
	[Token(Token = "0x2001C41")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB80C", Offset = "0x10FB80C")]
	internal abstract class UIInventoryItemControllerBase : UIBaseController
	{
		// Token: 0x06009D3D RID: 40253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D3D")]
		[Address(RVA = "0x191860C", Offset = "0x191860C", VA = "0x7BBC11860C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009D3E RID: 40254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D3E")]
		[Address(RVA = "0x19188A0", Offset = "0x19188A0", VA = "0x7BBC1188A0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009D3F RID: 40255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D3F")]
		[Address(RVA = "0x1918988", Offset = "0x1918988", VA = "0x7BBC118988")]
		public UIItem GetUIItem()
		{
			return null;
		}

		// Token: 0x06009D40 RID: 40256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D40")]
		[Address(RVA = "0x1918990", Offset = "0x1918990", VA = "0x7BBC118990", Slot = "28")]
		public virtual AHtazwI GetItem()
		{
			return null;
		}

		// Token: 0x06009D41 RID: 40257 RVA: 0x00029298 File Offset: 0x00027498
		[Token(Token = "0x6009D41")]
		[Address(RVA = "0x19189A8", Offset = "0x19189A8", VA = "0x7BBC1189A8", Slot = "29")]
		public virtual int GetCount()
		{
			return 0;
		}

		// Token: 0x06009D42 RID: 40258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D42")]
		[Address(RVA = "0x19189C0", Offset = "0x19189C0", VA = "0x7BBC1189C0", Slot = "30")]
		public virtual void OnDrapStart()
		{
		}

		// Token: 0x06009D43 RID: 40259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D43")]
		[Address(RVA = "0x1918E94", Offset = "0x1918E94", VA = "0x7BBC118E94")]
		public void Update()
		{
		}

		// Token: 0x06009D44 RID: 40260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D44")]
		[Address(RVA = "0x1919208", Offset = "0x1919208", VA = "0x7BBC119208")]
		public void ResetNoDrag()
		{
		}

		// Token: 0x06009D45 RID: 40261 RVA: 0x000292B0 File Offset: 0x000274B0
		[Token(Token = "0x6009D45")]
		[Address(RVA = "0x1919328", Offset = "0x1919328", VA = "0x7BBC119328", Slot = "31")]
		public virtual bool OnDrapRelease(UIInventoryItemDragDropContainer container)
		{
			return default(bool);
		}

		// Token: 0x06009D46 RID: 40262 RVA: 0x000292C8 File Offset: 0x000274C8
		[Token(Token = "0x6009D46")]
		[Address(RVA = "0x19196B8", Offset = "0x19196B8", VA = "0x7BBC1196B8", Slot = "32")]
		protected virtual bool HandleReleaseEvent(UIInventoryItemDragDropContainer container)
		{
			return default(bool);
		}

		// Token: 0x06009D47 RID: 40263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D47")]
		[Address(RVA = "0x19196C0", Offset = "0x19196C0", VA = "0x7BBC1196C0", Slot = "33")]
		protected virtual void OnItemToggleChanged()
		{
		}

		// Token: 0x06009D48 RID: 40264
		[Token(Token = "0x6009D48")]
		public abstract UIToggle GetToggle();

		// Token: 0x06009D49 RID: 40265
		[Token(Token = "0x6009D49")]
		public abstract GameObject GetHighlightGO();

		// Token: 0x06009D4A RID: 40266
		[Token(Token = "0x6009D4A")]
		public abstract GameObject GetDragGO();

		// Token: 0x06009D4B RID: 40267
		[Token(Token = "0x6009D4B")]
		public abstract GameObject GetNonDragGO();

		// Token: 0x06009D4C RID: 40268
		[Token(Token = "0x6009D4C")]
		public abstract GameObject GetDragRedGo();

		// Token: 0x06009D4D RID: 40269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D4D")]
		[Address(RVA = "0x1919968", Offset = "0x1919968", VA = "0x7BBC119968")]
		protected UIInventoryItemControllerBase()
		{
		}

		// Token: 0x0400A330 RID: 41776
		[Token(Token = "0x400A330")]
		[FieldOffset(Offset = "0x58")]
		protected UIItem m_Item;

		// Token: 0x0400A331 RID: 41777
		[Token(Token = "0x400A331")]
		[FieldOffset(Offset = "0x60")]
		private bool m_DragIn;
	}
}
