﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CollisionDetection.Contracts;
using BaseTypes;

namespace CollisionDetection.CollisionDetectors.ElementFinders
{
    public class SimpleElementFinder : ICollidingElementFinder
    {
        List<IWorldElement> ICollidingElementFinder.FindCollidingElements(IWorldElement element, ISimpleCollisionModel newPositionOnRoomFieldModel, IEnumerable<IWorldElement> allElements)
        {
            List<IWorldElement> result = new List<IWorldElement>();

            foreach (IWorldElement otherElement in allElements)
            {
                if (otherElement != element && !otherElement.IsVirtual)
                {
                    if (newPositionOnRoomFieldModel.EventuallyCollidesWith(otherElement.MyCollisionModel))
                    {
                        if (otherElement is IComposition)
                        {
                            IComposition parent = (IComposition)otherElement;
                            if (parent.Children.Count > 0)
                            {
                                result.AddRange(((ICollidingElementFinder)this).FindCollidingElements(
                                    element,
                                    newPositionOnRoomFieldModel,
                                    parent.Children));
                            }
                        }
                        else
                            result.Add(otherElement);
                    }
                }
            }
            return result;
        }
    }
}
